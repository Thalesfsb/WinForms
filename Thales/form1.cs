using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string curFile = "c:\\teste\\acme.sqlite";

            if (!File.Exists(curFile))
            {
                DataBaseConnection.DbConnection();
                DataBaseConnection.CriarTabela();
            }

            ExibirDados();

            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DataBaseConnection.Get();

                lvwVOO.Items.Clear();

                ListViewItem item;

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    item = new ListViewItem();
                    item.Text = dt.Rows[r].ItemArray[0].ToString();

                    for (int c = 1; c < dt.Columns.Count; c++)
                        item.SubItems.Add(dt.Rows[r].ItemArray[c].ToString());

                    lvwVOO.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private bool ValidaCampos()
        {

            Regex rgx = new Regex(@"[0-9]");

            if (rgx.IsMatch(tbCusto.Text) && rgx.IsMatch(tbDistancia.Text) && rgx.IsMatch(tbNivel.Text))
            {
                int nivelDor = Convert.ToInt32(tbNivel.Text);

                if (string.IsNullOrEmpty(mtbData.Text) && string.IsNullOrEmpty(tbCusto.Text) && string.IsNullOrEmpty(tbDistancia.Text) && string.IsNullOrEmpty(tbNivel.Text) && nivelDor <= 10 && rbNao.Checked == false && rbSim.Checked == false)
                    return false;
                else
                    return true;
            }

            return false;
        }

        private void LimparDados()
        {
            mtbData.Text = "";
            tbCusto.Text = "";
            tbDistancia.Text = "";
            rbNao.Checked = false;
            rbSim.Checked = false;
            tbNivel.Text = "";
        }

        private void IncluirDados(VOO voo)
        {
            try
            {
                if (!ValidaCampos())
                {
                    MessageBox.Show("Informe os dados do VOO corretamente");
                    return;
                }

                DataBaseConnection.Add(voo);
                ExibirDados();
                LimparDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                MessageBox.Show("Informe os dados do VOO corretamente");
                return;
            }

            VOO voo = new VOO();
            mtbData.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            voo.DATA_VOO = Convert.ToDateTime(mtbData.Text);
            voo.CUSTO = Convert.ToDouble(tbCusto.Text);
            voo.DISTANCIA = Convert.ToInt32(tbDistancia.Text);
            voo.CAPTURA = rbNao.Checked == true ? 'N' : 'S';
            voo.NIVEL_DOR = Convert.ToInt32(tbNivel.Text);

            IncluirDados(voo);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                lvwVOO.Items.RemoveAt(lvwVOO.SelectedIndices[0]);

                DataBaseConnection.Delete(ID_VOO);
                LimparDados();
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lvwVOO_Click(object sender, EventArgs e)
        {
            int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);

            DataTable voo = DataBaseConnection.GetVOO(ID_VOO);

            mtbData.Text = voo.Rows[0].ItemArray[0].ToString();
            tbCusto.Text = voo.Rows[0].ItemArray[1].ToString();
            tbDistancia.Text = voo.Rows[0].ItemArray[2].ToString();

            if (voo.Rows[0].ItemArray[3].ToString().Contains('S'))
                rbSim.Checked = true;
            else
                rbNao.Checked = true;

            tbNivel.Text = voo.Rows[0].ItemArray[4].ToString();

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);

            DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);
            VOO voo = new VOO();

            if (!ValidaCampos())
            {
                MessageBox.Show("Informe os dados do VOO corretamente");
                return;
            }

            if (dtVoo.Rows.Count > 0)
            {
                voo.ID_VOO = ID_VOO;
                mtbData.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                voo.DATA_VOO = Convert.ToDateTime(mtbData.Text);
                voo.CUSTO = Convert.ToDouble(tbCusto.Text);
                voo.DISTANCIA = Convert.ToInt32(tbDistancia.Text);
                voo.CAPTURA = rbNao.Checked == true ? 'N' : 'S';
                voo.NIVEL_DOR = Convert.ToInt32(tbNivel.Text);

                DataBaseConnection.Update(voo);
                LimparDados();
                ExibirDados();
            }
            else
            {
                mtbData.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                voo.DATA_VOO = Convert.ToDateTime(mtbData.Text);
                voo.CUSTO = Convert.ToDouble(tbCusto.Text);
                voo.DISTANCIA = Convert.ToInt32(tbDistancia.Text);
                voo.CAPTURA = rbNao.Checked == true ? 'N' : 'S';
                voo.NIVEL_DOR = Convert.ToInt32(tbNivel.Text);

                IncluirDados(voo);
            }

            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
            ExibirDados();
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void tbNivel_TextChanged(object sender, EventArgs e)
        {
            string nivelDor = tbNivel.Text;

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (nivelDor != dtVoo.Rows[0].ItemArray[4].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }


        }

        private void mtbData_TextChanged(object sender, EventArgs e)
        {
            mtbData.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            string data_voo = mtbData.Text.Replace("/", "-");

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);

                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (data_voo != dtVoo.Rows[0].ItemArray[0].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }
        }

        private void tbCusto_TextChanged(object sender, EventArgs e)
        {
            string custo = tbCusto.Text;

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (custo != dtVoo.Rows[0].ItemArray[1].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }


        }

        private void tbDistancia_TextChanged(object sender, EventArgs e)
        {
            string distancia = tbDistancia.Text;

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (distancia != dtVoo.Rows[0].ItemArray[2].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            char nao = rbNao.Checked == true ? 'N' : 'S';

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (nao.ToString() != dtVoo.Rows[0].ItemArray[3].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                        //rbSim.Checked = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }

        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            char sim = rbSim.Checked == true ? 'S' : 'N';

            if (lvwVOO.SelectedItems.Count > 0)
            {
                int ID_VOO = Convert.ToInt32(lvwVOO.SelectedItems[0].SubItems[0].Text);
                DataTable dtVoo = DataBaseConnection.GetVOO(ID_VOO);

                if (dtVoo.Rows.Count > 0)
                {
                    if (sim.ToString() != dtVoo.Rows[0].ItemArray[3].ToString())
                    {
                        btSalvar.Enabled = true;
                        btCancelar.Enabled = true;
                    }
                    else if (btCancelar.Enabled == true)
                    {
                        btSalvar.Enabled = false;
                        btCancelar.Enabled = false;
                    }
                }
            }

        }
    }
}
