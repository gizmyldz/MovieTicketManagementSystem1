using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




public class BaseForm : Form
{
    public BaseForm()
    {
        this.StartPosition = FormStartPosition.CenterScreen;
        this.WindowState = FormWindowState.Maximized; // Ekranı kapla
        this.FormBorderStyle = FormBorderStyle.Sizable; // Yeniden boyutlandırılabilir
    }
}