using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace балд
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         //Функция добавления в список слов введенного слова, а также подсчет очков.
        static void listadd(ref bool player, ListBox lst1, ListBox lst2, string rts, ref int q1, ref int q2)
        {
            if (player)
            {
                lst1.Items.Add(rts);
                player = false;
                q1 += rts.Length;
            }
            else
            {
                lst2.Items.Add(rts);
                player = true;
                q2 += rts.Length;
            }
        }

    }
}
