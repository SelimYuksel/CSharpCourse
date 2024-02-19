using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 1 çalıştı");   
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem 2 çalıştı");
        }
    }

    // Windows formlarda default olarak 1 thread çalışır. 
    // 2 butondan herhangi birisine bastığımızda sadece tek bir işlem devreye girebilir. 
    // Diğer işlemi açabilmek için açık olan işlemi kapatmak durumunda kalırız.
    // Multi threading yaparsak, her işlem için ayrı ayrı thread oluştururuz.
    // Her işlem kendi başına threadlerde çalışabilir
    // Asenkron programlama uygularsak, 1 thread üzerinde 2 işlem farklı zamanlarda çalışabilir(asenkron olarak)
}
