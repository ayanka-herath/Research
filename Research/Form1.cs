using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Research
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Tokenization button
        {
            SQL_txtbox.CharacterCasing = CharacterCasing.Upper;
            String a = SQL_txtbox.Text;
            string[] sentence = a.Split(',', ' ', '.');
            tok_txtbox.ForeColor = Color.DodgerBlue;
            tok_txtbox.Text = String.Join("/", sentence);

        }

        public void POS_TAG_btn_Check_Length_table1(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name)
        {
            if (syntax_format[3] == sentence[4])
            {
                POSTag_txtbox.Text = "SELECT * --> no || WHERE --> σ || " + " Table Name --> " + table_name[0] + " || " + "Condition --> " + sentence[5];

            }
            else if (table_name[0] == sentence[3] || table_name[0] == sentence[4])
            {
                if (table_name[1] == sentence[3] || table_name[1] == sentence[4])
                {
                    POSTag_txtbox.Text = "SELECT * --> no || " + " Table Name --> " + table_name[0] + " || " + " Table Name --> " + table_name[1];
                }
                else
                {
                    POSTag_txtbox.ForeColor = Color.Red;
                    POSTag_txtbox.Text = "Syntax Error.";
                }

            }
            else
            {
                POSTag_txtbox.ForeColor = Color.Red;
                POSTag_txtbox.Text = "Syntax Error.Where is missing.";
            }
        }

        public void POS_TAG_btn_Check_Length_table2(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name)
        {
            if (syntax_format[3] == sentence[4])
            {
                POSTag_txtbox.Text = "SELECT * --> no || WHERE --> σ || " + " Table Name --> " + table_name[1] + " || " + "Condition --> " + sentence[5];

            }
            else if (table_name[0] == sentence[3] || table_name[0] == sentence[4])
            {
                if (table_name[1] == sentence[3] || table_name[1] == sentence[4])
                {
                    POSTag_txtbox.Text = "SELECT * --> no || " + " Table Name --> " + table_name[0] + " || " + " Table Name --> " + table_name[1];
                }
                else
                {
                    POSTag_txtbox.ForeColor = Color.Red;
                    POSTag_txtbox.Text = "Syntax Error.";
                }

            }
            else
            {
                POSTag_txtbox.ForeColor = Color.Red;
                POSTag_txtbox.Text = "Syntax Error.Where is missing.";
            }
        }

        public void POS_TAG_btn_natural_join(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name)
        {
            int j = 1;
            int k = 0;
            int i = 0;
            int var1 = 1;
            int var2 = 0;
            int var3 = 0;
            while (sentence[var1] != "FROM") // to get size of printtable[] and print_filed[]
            {
                if (var1 % 2 == 0)
                {
                    var2 = var2 + 1;
                }
                else
                {
                    var3 = var3 + 1;
                }
                var1 = var1 + 1;
            }

            string[] print_tble = new string[var2];
            string[] print_feild = new string[var3];
            while (sentence[j] != "FROM") // store table an field names seperate arrays
            {
                if (j % 2 == 0)
                {
                    print_feild[k] = sentence[j];
                    k = k + 1;
                }
                else
                {
                    print_tble[i] = sentence[j];
                    i = i + 1;
                }
                j = j + 1;

            }

            if (sentence[j + 1] == table_name[0] || sentence[j + 1] == table_name[1])
            {
                if (sentence[j + 2] == table_name[0] || sentence[j + 2] == table_name[1])
                {
                    if (sentence.Length > 5)
                    {
                        if (sentence[j + 3] == syntax_format[3])
                        {
                            POSTag_txtbox.Text = "SELECT --> π ||";
                            for (int m = 0; m < print_feild.Length; m++)
                            {
                                POSTag_txtbox.Text = POSTag_txtbox.Text + "Field Name --> " + print_feild[m] + " || ";
                            }
                            POSTag_txtbox.Text = POSTag_txtbox.Text + "Table Name -- >" + sentence[j + 1] + " || Join Symbol --> " + symbols[2] + " Table name --> " + sentence[j + 2];
                        }

                    }

                }
            }
        }

        public void POS_TAG_btn_where_coondition_table1(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name,string[] emp_field,int i)
        {
            if (sentence.Length > 5)
            {
                if (sentence[i + 2] == syntax_format[3])
                {
                    for (int m = 1; m < i; m++)
                    {
                        for (int x = 0; x < emp_field.Length; x++)
                        {
                            if (sentence[m] == emp_field[x])
                            {
                                POSTag_txtbox.Text = POSTag_txtbox.Text + "Feild Name -->" + emp_field[x] + " || ";
                            }

                        }
                    }
                    POSTag_txtbox.Text = POSTag_txtbox.Text + "WHERE -- >" + symbols[1] + " || " + sentence[i + 3] + "-->" + sentence[i + 3] + " || " + " Table Name  --> " + table_name[0];
                }
                else
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.Where is missing";
                }
            }

            else
            {
                for (int m = 1; m < i; m++)
                {
                    for (int x = 0; x < emp_field.Length; x++)
                    {
                        if (sentence[m] == emp_field[x])
                        {
                            POSTag_txtbox.Text = POSTag_txtbox.Text + "Field Name -->" + emp_field[x] + " || ";
                        }
                    }
                }
                POSTag_txtbox.Text = POSTag_txtbox.Text + " || " + "Table Name  --> " + table_name[0];
            }
        }

        public void POS_TAG_btn_where_coondition_table2(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name, string[] dep_field, int i)
        {
            if (sentence.Length > 5) // more fields with where condition
            {
                if (sentence[i + 2] == syntax_format[3])
                {
                    for (int l = 1; l < i; l++)
                    {
                        for (int n = 0; n < dep_field.Length; n++)
                        {
                            if (sentence[l] == dep_field[n])
                            {
                                POSTag_txtbox.Text = POSTag_txtbox.Text + "Field Name -->" + dep_field[n] + " || "; ;
                            }
                        }
                    }
                    POSTag_txtbox.Text = POSTag_txtbox.Text + "WHERE -- >" + symbols[1] + " || " + sentence[i + 3] + "-->" + sentence[i + 3] + " || " + "Table Name  --> " + table_name[1];
                }
                else
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.Where is missing";
                }
            }

            else // more feilds without where condition
            {
                for (int l = 1; l < i; l++) 
                {
                    for (int n = 0; n < dep_field.Length; n++)
                    {
                        if (sentence[l] == dep_field[n])
                        {
                            POSTag_txtbox.Text = POSTag_txtbox.Text + "Field Name -->" + dep_field[n] + " || ";
                        }
                    }
                }
                POSTag_txtbox.Text = POSTag_txtbox.Text + " || " + "Table Name --> " + table_name[1];
            }
        }

        private void button3_Click(object sender, EventArgs e) //POS Tag button
        {
            SQL_txtbox.CharacterCasing = CharacterCasing.Upper;
            String a = SQL_txtbox.Text;

            string[] sentence = a.Split(' ', ',', '.');
            string[] syntax_format = { "SELECT", "*", "FROM", "WHERE" };
            string[] table_name = { "EMPLOYEE", "DEPARTMENT" };
            string[] emp_field = { "FNAME", "LNAME", "ADDRESS", "AGE", "DNO"};
            string[] dep_field = { "DNO", "DNAME" };
            string[] symbols = { "π ", "σ", "⋈" };


            if (sentence[0] == syntax_format[0]) //Select
            {
                if (sentence[1] == syntax_format[1]) //*
                {
                    if (sentence[2] == syntax_format[2]) //from
                    {
                        if (sentence[3] == table_name[0]) //Check table 1
                        {
                            if (sentence.Length > 4)
                            {
                                POS_TAG_btn_Check_Length_table1(syntax_format, sentence, symbols, table_name);
                            }

                            else
                            {
                                POSTag_txtbox.Text = "SELECT * --> no " + " Table Name  --> " + table_name[0];
                            }

                        }
                        else if (sentence[3] == table_name[1]) // check table 2
                        {
                            if (sentence.Length > 4)
                            {
                                POS_TAG_btn_Check_Length_table2(syntax_format, sentence, symbols, table_name);
                            }

                            else
                            {
                                POSTag_txtbox.Text = "SELECT * --> no " + " Table Name  --> " + table_name[1];
                            }

                       }
                       else
                       {
                            POSTag_txtbox.ForeColor = Color.Red;
                            POSTag_txtbox.Text = "Syntax Error.Table name is wrong.";
                       }
                    }

                    else
                    {
                        POSTag_txtbox.ForeColor = Color.Red;
                        POSTag_txtbox.Text = "Sysntax error.";
                    }

                }

                //////normal where condition//////////
                else
                {
                    if (sentence[1] == table_name[0] || sentence[1] == table_name[1]) // natural join
                    {
                        POS_TAG_btn_natural_join(syntax_format, sentence, symbols, table_name);
                    }
                    else // where condition
                    {
                        int i = 1;

                        while (sentence[i] != "FROM")
                        {
                            i = i + 1;

                        }
                        POSTag_txtbox.Text = "SELECT --> π ||";
                        if (sentence[i + 1] == table_name[0]) //for table 1
                        {
                            POS_TAG_btn_where_coondition_table1(syntax_format, sentence, symbols, table_name, emp_field, i);
                        }

                        else if (sentence[i + 1] == table_name[1]) //for table 2
                        {
                            POS_TAG_btn_where_coondition_table2(syntax_format, sentence, symbols, table_name, dep_field, i);
                        }

                        else
                        {
                            POSTag_txtbox.ForeColor = Color.Red;
                            POSTag_txtbox.Text = "Sysntax error. check again table name";
                        }
                    }
                }

            }
                    

            else
            {
                POSTag_txtbox.ForeColor = Color.Red;
                POSTag_txtbox.Text = "Sysntax error. check again";
            }
        }

        public void Check_Length_table1(string[] syntax_format,string[] sentence,string[] symbols,string[] table_name)
        {
            if (syntax_format[3] == sentence[4]) // Check "WHERE"
            {
                syntax_txtbox.SelectedText = symbols[1];
                syntax_txtbox.SelectionCharOffset = -10; //subscript
                syntax_txtbox.SelectedText = sentence[5];
                syntax_txtbox.SelectionCharOffset = 0;
                syntax_txtbox.SelectedText = "(" + table_name[0] + ")";

            }
            //for select * join
            else if (table_name[0] == sentence[3] || table_name[0] == sentence[4]) // check table name
            {
                if (table_name[1] == sentence[3] || table_name[1] == sentence[4])
                {
                    syntax_txtbox.Text = table_name[0] + " X " + table_name[1];
                }
                else
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.";
                }

            }

            else
            {
                syntax_txtbox.ForeColor = Color.Red;
                syntax_txtbox.Text = "Syntax Error.check it again";
            }
        }

        public void Check_Length_table2(string[] syntax_format, string[] sentence, string[] symbols, string[] table_name)
        {
            if (syntax_format[3] == sentence[4])
            {
                syntax_txtbox.SelectedText = symbols[1];
                syntax_txtbox.SelectionCharOffset = -10; //subscript
                syntax_txtbox.SelectedText = sentence[5];
                syntax_txtbox.SelectionCharOffset = 0;
                syntax_txtbox.SelectedText= "(" + table_name[1] + ")";

            }
            //for select * join
            else if (table_name[0] == sentence[3] || table_name[0] == sentence[4])
            {
                if (table_name[1] == sentence[3] || table_name[1] == sentence[4])
                {
                    syntax_txtbox.Text = table_name[0] + " X " + table_name[1];
                }
                else
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.";
                }

            }

            else
            {
                syntax_txtbox.ForeColor = Color.Red;
                syntax_txtbox.Text = "Syntax Error.check it again";
            }
       }

        public void natural_join(string[] syntax_format, string[] sentence, string where_condition, string[] table_name,string[] symbols)
        {
            int j = 1;
            int k = 0;
            int i = 0;
            int var1 = 1;
            int var2 = 0;
            int var3 = 0;
            while (sentence[var1] != "FROM") // To set the size for print_tble[] and print_feild[]
            {
                if (var1 % 2 == 0)
                {
                    var2 = var2 + 1;
                }
                else
                {
                    var3 = var3 + 1;
                }
                var1 = var1 + 1;
            }
            syntax_txtbox.SelectedText = symbols[0];
            string[] print_tble = new string[var2];
            string[] print_feild = new string[var3];

            while (sentence[j] != "FROM") // Store tables and feilds values up to "FROM" seperatly
            {
                if (j % 2 == 0)
                {
                    print_feild[k] = sentence[j];
                    k = k + 1;
                }
                else
                {
                    print_tble[i] = sentence[j];
                    i = i + 1;
                }
                j = j + 1;
            }

            if (sentence[j + 1] == table_name[0] || sentence[j + 1] == table_name[1])
            {
                if (sentence[j + 2] == table_name[0] || sentence[j + 2] == table_name[1])
                {
                    if (sentence.Length > 5)
                    {
                        if (sentence[j + 3] == syntax_format[3])
                        {
                            for (int m = 0; m < print_feild.Length; m++)
                            {
                                syntax_txtbox.SelectionCharOffset = -10;
                                syntax_txtbox.SelectedText = print_feild[m] + " ";
                            }
                            syntax_txtbox.SelectionCharOffset = 0;
                            syntax_txtbox.SelectedText = "(" + sentence[j + 1] +" " + symbols[2] + " " + sentence[j + 2] + ")";

                        }
                    }
                }
            }
        }

        public void where_condition_with_fields_table1(string[] syntax_format, string[] sentence, string where_condition, string[] table_name, string[] symbols,int i,string[] emp_field)
        {
            syntax_txtbox.SelectedText = symbols[0];
            if (sentence.Length > 5) // with where condition with feilds
            {
                if (sentence[i + 2] == syntax_format[3])
                {
                    for (int m = 1; m < i; m++)
                    {
                        for (int x = 0; x < emp_field.Length; x++)
                        {
                            if (sentence[m] == emp_field[x])
                            {
                                syntax_txtbox.SelectionCharOffset = -10;
                                syntax_txtbox.SelectedText = emp_field[x]+" ";
                            }
                        }
                    }
                    syntax_txtbox.SelectionCharOffset = 0;
                    syntax_txtbox.SelectedText = "( " + symbols[1];
                    syntax_txtbox.SelectionCharOffset = -10;
                    syntax_txtbox.SelectedText = sentence[i + 3]+" ";
                    syntax_txtbox.SelectionCharOffset = 0;
                    syntax_txtbox.SelectedText = " ( " + table_name[0] + " ) )";

                }
                else
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.Where is missing";
                }
            }

            else // For without where condition with feilds --> select fname,lname from employee
            {
                for (int m = 1; m < i; m++)
                {
                    for (int x = 0; x < emp_field.Length; x++)
                    {
                        if (sentence[m] == emp_field[x])
                        {
                            syntax_txtbox.SelectionCharOffset = -10;
                            //string str= emp_field[x];
                            syntax_txtbox.SelectedText = emp_field[x] + " ";
                        }
                    }
                }
                syntax_txtbox.SelectionCharOffset = 0;
                syntax_txtbox.SelectedText = " ( " + table_name[0] + " )";
            }
        }

        public void where_condition_with_fields_table2(string[] syntax_format, string[] sentence, string where_condition, string[] table_name, string[] symbols, int i, string[] dep_field)
        {
            syntax_txtbox.Text = symbols[0];
            if (sentence.Length > 5) // with where condition with feilds
            {
                if (sentence[i + 2] == syntax_format[3])
                {
                    for (int l = 1; l < i; l++)
                    {
                        for (int n = 0; n < dep_field.Length; n++)
                        {
                            if (sentence[l] == dep_field[n])
                            {
                                syntax_txtbox.SelectionCharOffset = -10;
                                print_comma(dep_field);
                                syntax_txtbox.SelectedText = dep_field[n] + " ";
                            }
                        }
                    }
                    syntax_txtbox.SelectionCharOffset = 0;
                    syntax_txtbox.SelectedText = "( " + symbols[1];
                    syntax_txtbox.SelectionCharOffset = -10;
                    syntax_txtbox.SelectedText = sentence[i + 3] + " ";
                    syntax_txtbox.SelectionCharOffset = 0;
                    syntax_txtbox.SelectedText = " ( " + table_name[1] + " ) )";
                }
                else 
                {
                    syntax_txtbox.ForeColor = Color.Red;
                    syntax_txtbox.Text = "Syntax Error.Where is missing";
                }
            }

            else // For without where condition with feilds --> select Dno,Dname from department
            {
                for (int l = 1; l < i; l++)
                {
                    for (int n = 0; n < dep_field.Length; n++)
                    {
                        if (sentence[l] == dep_field[n])
                        {
                            syntax_txtbox.SelectionCharOffset = -10;
                            syntax_txtbox.SelectedText = dep_field[n] + " ";
                        }
                    }
                }
                syntax_txtbox.SelectionCharOffset = 0;
                syntax_txtbox.SelectedText = " ( " + table_name[1] + " )";
            }
        }
        //to print comma
        public void print_comma(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var var = arr[i];
                if (i != -1)
                {
                    var word = String.Join(",", arr[i]);
                }
            }
            
        }

        private void Syntax_btn_Click(object sender, EventArgs e)
        {
            SQL_txtbox.CharacterCasing = CharacterCasing.Upper;
            String a = SQL_txtbox.Text;

            string[] sentence = a.Split(' ', ',', '.');
            string[] syntax_format = { "SELECT", "*", "FROM", "WHERE" };
            string[] table_name = { "EMPLOYEE", "DEPARTMENT" };
            string[] emp_field = { "FNAME", "LNAME", "ADDRESS", "AGE", "DNO" };
            string[] dep_field = { "DNO", "DNAME" };
            string[] symbols = { "π ", "σ", "⋈" };
            String where_condition = "σ";

            if (sentence[0] == syntax_format[0]) // select
            {
                if (sentence[1] == syntax_format[1]) // *
                {
                    if (sentence[2] == syntax_format[2]) // from
                    {
                        if (sentence[3] == table_name[0]) // check table1
                        {
                            if (sentence.Length > 4)
                            {
                                Check_Length_table1(syntax_format,sentence,symbols,table_name);
                            }
                            else
                            {
                                syntax_txtbox.Text = sentence[3];
                            }
                            
                        }
                        else if (sentence[3] == table_name[1]) //check table2
                        {
                            if (sentence.Length > 4)
                            {
                                Check_Length_table2(syntax_format, sentence, symbols, table_name);
                            }

                            else
                            {
                                syntax_txtbox.Text = sentence[3];
                            }

                        }
                        else //print error if not in same table
                        {
                            syntax_txtbox.ForeColor = Color.Red;
                            syntax_txtbox.Text = "Sysntax error. check again table name.";
                        }
                    }

                    else
                    {
                        syntax_txtbox.ForeColor = Color.Red;
                        syntax_txtbox.Text = "Sysntax error. ";
                    }
                }

                else // select with field (not equal to "FROM")
                {       
                        //join
                        if (sentence[1] == table_name[0] || sentence[1] == table_name[1])
                        {
                            natural_join(syntax_format, sentence, where_condition, table_name, symbols);
                        }
                        //normal where condition
                        else
                        {
                            int i = 1;

                            while (sentence[i] != "FROM")
                            {
                                i = i + 1;
                            }

                            if (sentence[i + 1] == table_name[0])
                            {
                                where_condition_with_fields_table1(syntax_format, sentence, where_condition, table_name,symbols,i,emp_field);
                            }

                            else if (sentence[i + 1] == table_name[1])
                            {
                                where_condition_with_fields_table1(syntax_format, sentence, where_condition, table_name, symbols, i, dep_field);
                            }

                            else
                            {
                                syntax_txtbox.ForeColor = Color.Red;
                                syntax_txtbox.Text = "Sysntax error. check again table name";
                            }
                       }
                  }
            }
            else // not similar to SELECT
            {
                syntax_txtbox.ForeColor = Color.Red;
                syntax_txtbox .Text = "Sysntax error. check again";
            }

        }


        private void SQL_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tok_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void syntax_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            SQL_txtbox.Clear();
            tok_txtbox.Clear();
            tok_txtbox.ForeColor = Color.DodgerBlue;
            syntax_txtbox.Clear();
            syntax_txtbox.ForeColor = Color.DodgerBlue;
            POSTag_txtbox.Clear();
            POSTag_txtbox.ForeColor = Color.DodgerBlue;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void POSTag_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

