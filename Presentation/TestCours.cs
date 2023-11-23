using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class TestCours : Form {

    List<string> liste = new List<string>() {
        "aaa",
        "aab",
        "aba",
        "abb",
        "baa",
        "bab",
        "bba",
        "bbb"
    };

    public TestCours() {
        InitializeComponent();
        this.comboBox1.DataSource = liste;
        this.comboBox1.SelectedIndex = 6;

    }


    private List<string> FilterListBox(string userInput) {
        return this.liste.Where(stringValue => {
            return stringValue.StartsWith(userInput);
        }).ToList();
    }


    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
        if (this.textBox1.Text.Length >= 1) {
            this.listBox1.DataSource = this.FilterListBox(this.textBox1.Text);
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
        List<string> selectedItems = this.listBox1.SelectedItems.Cast<string>().ToList();
        string displayText = "";
        foreach (string item in selectedItems) {
            displayText += " " + item;
        }
        this.textBox2.Text = displayText;
    }

    private void button1_MouseEnter(object sender, EventArgs e) {
        this.switchForeAndBackColors((Control) sender);
    }

    private void button1_MouseLeave(object sender, EventArgs e) {
        this.switchForeAndBackColors((Control) sender);
    }

    private void switchForeAndBackColors(Control control) {
        (control.ForeColor, control.BackColor) = (control.BackColor, control.ForeColor);
    }
}
