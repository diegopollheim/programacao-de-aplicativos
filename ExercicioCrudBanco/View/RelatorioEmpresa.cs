using ExercicioCrudBanco.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCrudBanco.View
{
    public partial class RelatorioEmpresa : Form
    {
        public RelatorioEmpresa()
        {
            InitializeComponent();

            EmpresaController controller = new EmpresaController();
            dgvEmpresas.DataSource = controller.BuscarTodasEmpresas();
        }
    }
}
