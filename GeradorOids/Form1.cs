using System.Xml.Linq;

namespace GeradorOids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione a pasta desejada:";
                folderDialog.UseDescriptionForTitle = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSelectedPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ipFornecido.Text) || !string.IsNullOrWhiteSpace(txtSelectedPath.Text))
            {
                OidBusca busca = new OidBusca(ipFornecido.Text, txtSelectedPath.Text);
                busca.Busca();
                conclusao.Visible = true;
            }
        }
    }
}
