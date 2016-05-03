using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Serializer : Form
    {
        public Person Person { get; } = new Person();

        public Serializer()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Person.Name = name_textBox.Text;
            Person.Address = address_textBox.Text;
            Person.Phone = int.Parse(phone_txtbox.Text);
            Person.Serialize(Person);
        }
    }
}
