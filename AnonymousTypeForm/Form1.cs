using AnonymousTypeForm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousTypeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            using(MyContext db = new MyContext())
            {
                dataGridView1.DataSource = db.Players.Include(t => t.Team).ToList();
                //dataGridView1.DataSource = db.Players.Local.ToBindingList();
                //var players = db.Players.Join(db.Teams,



                //    p => p.Id, t => t.Id, (p, t) => new
                //    {
                //        player = p.Name,
                //        age = p.Age,
                //        team = t.Name

                //    }
                //    ) ;
                //var players2 = db.Players.Join(db.Teams,
                // dataGridView1.DataSource = players.ToList() ;
            }
        }
    }
}
