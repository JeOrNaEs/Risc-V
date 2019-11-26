using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int zeroi = 0;
        int rai = 0;
        int spi = 0;
        int gpi = 0;
        int tpi = 0;
        int t0i = 0;
        int t1i = 0;
        int t2i = 0;
        int s0i = 0;
        int s1i = 0;
        int a0i = 0;
        int a1i = 0;
        int a2i = 0;
        int a3i = 0;
        int a4i = 0;
        int a5i = 0;
        int a6i = 0;
        int a7i = 0;
        int s2i = 0;
        int s3i = 0;
        int s4i = 0;
        int s5i = 0;
        int s6i = 0;
        int s7i = 0;
        int s8i = 0;
        int s9i = 0;
        int s10i = 0;
        int s11i = 0;
        int t3i = 0;
        int t4i = 0;
        int t5i = 0;
        int t6i = 0;
        int pci = 0;
        String zero = "";
        String ra = "";
        String sp = "";
        String gp = "";
        String tp = "";
        String t0 = "";
        String t1 = "";
        String t2 = "";
        String s0 = "";
        String s1 = "";
        String a0 = "";
        String a1 = "";
        String a2 = "";
        String a3 = "";
        String a4 = "";
        String a5 = "";
        String a6 = "";
        String a7 = "";
        String s2 = "";
        String s3 = "";
        String s4 = "";
        String s5 = "";
        String s6 = "";
        String s7 = "";
        String s8 = "";
        String s9 = "";
        String s10 = "";
        String s11 = "";
        String t3 = "";
        String t4 = "";
        String t5 = "";
        String t6 = "";
        String pc = "";
        public Form1()
        {
            InitializeComponent();
            Registro_Datos.Rows.Add("Zero", "00000000000000000000000000000000", "Alambrado a cero");
            Registro_Datos.Rows.Add("ra", "00000000000000000000000000000000", "Dirección de retorno");
            Registro_Datos.Rows.Add("sp", "00000000000000000000000000000000", "Stack pointer");
            Registro_Datos.Rows.Add("gp", "00000000000000000000000000000000", "Global pointer");
            Registro_Datos.Rows.Add("tp", "00000000000000000000000000000000", "Thread pointer");
            Registro_Datos.Rows.Add("t0", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("t1", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("t2", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("s0 / fp", "00000000000000000000000000000000", "Saved register, frame pointer");
            Registro_Datos.Rows.Add("s1", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("a0", "00000000000000000000000000000000", "Argumento de función, valor de retorno");
            Registro_Datos.Rows.Add("a1", "00000000000000000000000000000000", "Argumento de función, valor de retorno");
            Registro_Datos.Rows.Add("a2", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("a3", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("a4", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("a5", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("a6", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("a7", "00000000000000000000000000000000", "Argumento de función");
            Registro_Datos.Rows.Add("s2", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s3", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s4", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s5", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s6", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s7", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s8", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s9", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s10", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("s11", "00000000000000000000000000000000", "Saved register");
            Registro_Datos.Rows.Add("t3", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("t4", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("t5", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("t6", "00000000000000000000000000000000", "Temporal");
            Registro_Datos.Rows.Add("pc", "00000000000000000000000000000000", "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "PC";
            label1.Visible = true;
            Graphics golfgti6;
            golfgti6 = pictureBox1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 1);
            Pen blackPen2 = new Pen(Color.Black, 3);
            golfgti6.DrawRectangle(blackPen, 10, 50, 30, 55);
            golfgti6.DrawLine(blackPen2, 25, 0, 25, 50);
            golfgti6.DrawLine(blackPen2, 25, 0, 860, 0);
            golfgti6.DrawLine(blackPen2, 860, 0, 860, 60);
            golfgti6.DrawLine(blackPen2, 830, 60, 860, 60);
            golfgti6.DrawEllipse(blackPen, 800, 20, 30, 120);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            golfgti6.DrawLine(blackPen2, 25, 105, 25, 160);
            golfgti6.DrawRectangle(blackPen, 5, 160, 200, 210);
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            golfgti6.DrawLine(blackPen2, 25, 125, 75, 125);
            golfgti6.DrawEllipse(blackPen2, 22, 122, 5, 5);
            golfgti6.DrawLine(blackPen2, 74, 126, 74, 45);
            golfgti6.DrawLine(blackPen2, 74, 44, 194, 44);
            golfgti6.DrawLine(blackPen, 194, 24, 194, 64);
            golfgti6.DrawLine(blackPen, 194, 64, 204, 69);
            golfgti6.DrawLine(blackPen, 204, 69, 194, 74);
            golfgti6.DrawLine(blackPen, 194, 74, 194, 114);
            golfgti6.DrawLine(blackPen, 274, 44, 274, 94);
            golfgti6.DrawLine(blackPen, 194, 24, 274, 44);
            golfgti6.DrawLine(blackPen, 274, 94, 194, 114);
            golfgti6.DrawLine(blackPen2, 174, 94, 194, 94);
            label13.Visible = true;
            label14.Visible = true;
            golfgti6.DrawLine(blackPen2, 274, 67, 670, 67);
            golfgti6.DrawLine(blackPen, 670, 44, 670, 84);
            golfgti6.DrawLine(blackPen, 670, 84, 680, 89);
            golfgti6.DrawLine(blackPen, 680, 89, 670, 94);
            golfgti6.DrawLine(blackPen, 670, 94, 670, 134);
            golfgti6.DrawLine(blackPen, 750, 64, 750, 114);
            golfgti6.DrawLine(blackPen, 670, 44, 750, 64);
            golfgti6.DrawLine(blackPen, 670, 134, 750, 114);
            label15.Visible = true;
            golfgti6.DrawEllipse(blackPen2, 652, 65, 5, 5);
            golfgti6.DrawLine(blackPen2, 655, 67, 655, 30);
            golfgti6.DrawLine(blackPen2, 655, 30, 808, 30);
            golfgti6.DrawLine(blackPen2, 685, 90, 800, 90);

            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawEllipse(blackPen2, 224, 188, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 230, 350, 230);
            golfgti6.DrawEllipse(blackPen2, 224, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 350, 295, 350);
            golfgti6.DrawEllipse(blackPen2, 224, 348, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 190, 225, 430);
            golfgti6.DrawEllipse(blackPen, 290, 240, 30, 120);
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            golfgti6.DrawLine(blackPen, 270, 230, 270, 270);
            golfgti6.DrawEllipse(blackPen2, 268, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 270, 270, 290, 270);
            golfgti6.DrawLine(blackPen, 320, 305, 350, 305);

            golfgti6.DrawRectangle(blackPen, 350, 175, 150, 210);
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
            golfgti6.DrawLine(blackPen, 225, 430, 430, 430);
            golfgti6.DrawEllipse(blackPen, 430, 400, 60, 60);
            label41.Visible = true;
            label42.Visible = true;
            golfgti6.DrawEllipse(blackPen, 570, 80, 80, 80);
            label43.Visible = true;
            label44.Visible = true;
            golfgti6.DrawLine(blackPen2, 530, 120, 570, 120);
            golfgti6.DrawLine(blackPen2, 650, 120, 670, 120);
            golfgti6.DrawLine(blackPen2, 530, 120, 530, 430);
            golfgti6.DrawLine(blackPen2, 530, 430, 490, 430);
            golfgti6.DrawLine(blackPen2, 500, 200, 620, 200);
            golfgti6.DrawLine(blackPen2, 500, 245, 560, 245);
            golfgti6.DrawEllipse(blackPen, 558, 210, 30, 120);
            label45.Visible = true;
            label46.Visible = true;
            label47.Visible = true;
            label48.Visible = true;
            label49.Visible = true;
            golfgti6.DrawLine(blackPen2, 530, 295, 560, 295);
            golfgti6.DrawEllipse(blackPen2, 528, 292, 5, 5);
            golfgti6.DrawLine(blackPen, 620, 175, 620, 224);
            golfgti6.DrawLine(blackPen, 620, 224, 634, 229);
            golfgti6.DrawLine(blackPen, 634, 229, 620, 234);
            golfgti6.DrawLine(blackPen, 620, 234, 620, 284);
            golfgti6.DrawLine(blackPen, 730, 190, 730, 260);
            golfgti6.DrawLine(blackPen, 620, 175, 730, 190);
            golfgti6.DrawLine(blackPen, 620, 284, 730, 260);
            golfgti6.DrawLine(blackPen, 620, 284, 730, 260);
            golfgti6.DrawLine(blackPen, 620, 284, 730, 260);
            golfgti6.DrawLine(blackPen2, 620, 260, 588, 260);
            label50.Visible = true;
            label51.Visible = true;
            label52.Visible = true;
            golfgti6.DrawEllipse(blackPen2, 513, 243, 5, 5);
            golfgti6.DrawLine(blackPen2, 515, 245, 515, 380);
            golfgti6.DrawLine(blackPen2, 515, 380, 700, 380);
            golfgti6.DrawLine(blackPen2, 700, 380, 700, 300);
            golfgti6.DrawLine(blackPen2, 700, 300, 770, 300);
            golfgti6.DrawRectangle(blackPen, 770, 180, 120, 130);
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            label56.Visible = true;
            label57.Visible = true;
            label58.Visible = true;
            label59.Visible = true;
            label60.Visible = true;
            label61.Visible = true;
            label62.Visible = true;
            golfgti6.DrawLine(blackPen2, 730, 240, 770, 240);
            golfgti6.DrawEllipse(blackPen2, 748, 238, 5, 5);
            golfgti6.DrawLine(blackPen2, 750, 210, 750, 385);
            golfgti6.DrawLine(blackPen2, 750, 210, 770, 210);
            golfgti6.DrawLine(blackPen2, 750, 210, 750, 385);
            golfgti6.DrawLine(blackPen2, 750, 385, 915, 385);
            golfgti6.DrawEllipse(blackPen, 930, 185, 30, 120);
            golfgti6.DrawLine(blackPen2, 915, 385, 915, 285);
            golfgti6.DrawLine(blackPen2, 915, 285, 935, 285);
            label63.Visible = true;
            label64.Visible = true;
            label65.Visible = true;
            label66.Visible = true;
            label67.Visible = true;
            golfgti6.DrawLine(blackPen2, 890, 205, 935, 205);
            golfgti6.DrawLine(blackPen2, 960, 243, 990, 243);
            golfgti6.DrawLine(blackPen2, 990, 243, 990, 483);
            golfgti6.DrawLine(blackPen2, 990, 483, 330, 483);
            golfgti6.DrawLine(blackPen2, 330, 483, 330, 353);
            golfgti6.DrawLine(blackPen2, 330, 353, 350, 353);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binario = "";
            if (lstFunciones.Text.ToLower().Equals("addi"))
            {
                binario = "000000000";
                asignarVariable(txtRd.Text, txtRs2oInm.Text);
                binario += addi(lstFunciones.Text, txtRd.Text.ToLower(), txtRs1.Text.ToLower(), txtRs2oInm.Text.ToLower());
                label18.Text = binario;
            }
            if (lstFunciones.Text.ToLower().Equals("add"))
            {
                binario = "0000000";
                binario += add(lstFunciones.Text, txtRd.Text.ToLower(), txtRs1.Text.ToLower(), txtRs2oInm.Text.ToLower());
                label18.Text = binario;
            }
            if (lstFunciones.Text.ToLower().Equals("sub"))
            {
                binario = "0100000";
                binario += sub(lstFunciones.Text, txtRd.Text.ToLower(), txtRs1.Text.ToLower(), txtRs2oInm.Text.ToLower());
                label18.Text = binario;
            }
        }
        private void asignarVariableGrid(String variable, String valor){
            if (variable.Equals("t0"))
            {
                Registro_Datos.Rows[5].Cells[1].Value = valor;
            }
            if (variable.Equals("t1"))
            {
                Registro_Datos.Rows[6].Cells[1].Value = valor;
            }
            if (variable.Equals("t2"))
            {
                Registro_Datos.Rows[7].Cells[1].Value = valor;
            }
            if (variable.Equals("s0"))
            {
                Registro_Datos.Rows[8].Cells[1].Value = valor;
            }
            if (variable.Equals("s1"))
            {
                Registro_Datos.Rows[9].Cells[1].Value = valor;
            }
            if (variable.Equals("s2"))
            {
                Registro_Datos.Rows[18].Cells[1].Value = valor;
            }
            if (variable.Equals("s3"))
            {
                Registro_Datos.Rows[19].Cells[1].Value = valor;
            }
            if (variable.Equals("s4"))
            {
                Registro_Datos.Rows[20].Cells[1].Value = valor;
            }
            if (variable.Equals("s5"))
            {
                Registro_Datos.Rows[21].Cells[1].Value = valor;
            }
            if (variable.Equals("s6"))
            {
                Registro_Datos.Rows[22].Cells[1].Value = valor;
            }
            if (variable.Equals("s7"))
            {
                Registro_Datos.Rows[23].Cells[1].Value = valor;
            }
            if (variable.Equals("s8"))
            {
                Registro_Datos.Rows[24].Cells[1].Value = valor;
            }
            if (variable.Equals("s9"))
            {
                Registro_Datos.Rows[25].Cells[1].Value = valor;
            }
            if (variable.Equals("s10"))
            {
                Registro_Datos.Rows[26].Cells[1].Value = valor;
            }
            if (variable.Equals("s11"))
            {
                Registro_Datos.Rows[27].Cells[1].Value = valor;
            }
            if (variable.Equals("t3"))
            {
                Registro_Datos.Rows[28].Cells[1].Value = valor;
            }
            if (variable.Equals("t4"))
            {
                Registro_Datos.Rows[29].Cells[1].Value = valor;
            }
            if (variable.Equals("t5"))
            {
                Registro_Datos.Rows[30].Cells[1].Value = valor;
            }
            if (variable.Equals("t6"))
            {
                Registro_Datos.Rows[31].Cells[1].Value = valor;
            }
        }

        private int asignarVariable(String variable, String valor)
        {
            int valori = Convert.ToInt32(valor);
            if (variable.Equals("t0"))
            {
                if (lstFunciones.Text.Equals("Addi"))
                {
                    this.t0i = valori;
                }
                    return t0i;
            }
            if (variable.Equals("t1"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t1i = valori;
                }
                return t1i;
            }
            if (variable.Equals("t2"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t2i = valori;
                }
                return t2i;
            }
            if (variable.Equals("s0"))
            {
                if (lstFunciones.Text.Equals("Addi"))
                {
                    this.s0i = valori;
                }
                return s0i;
            }
            if (variable.Equals("s1"))
            {
                if (lstFunciones.Text.Equals("Addi"))
                {
                    this.s1i = valori;
                }
                return s1i;
            }
            if (variable.Equals("s2"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s2i = valori;
                }
                return s2i;
            }
            if (variable.Equals("s3"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s3i = valori;
                }
                return s3i;
            }
            if (variable.Equals("s4"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s4i = valori;
                }
                return s4i;
            }
            if (variable.Equals("s5"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s5i = valori;
                }
                return s5i;
            }
            if (variable.Equals("s6"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s6i = valori;
                }
                return s6i;
            }
            if (variable.Equals("s7"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s7i = valori;
                }
                return s7i;
            }
            if (variable.Equals("s8"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s8i = valori;
                }
                return s8i;
            }
            if (variable.Equals("s9"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s9i = valori;
                }
                return s9i;
            }
            if (variable.Equals("s10"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s10i = valori;
                }
                return s10i;
            }
            if (variable.Equals("s11"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    s11i = valori;
                }
                return s11i;
            }
            if (variable.Equals("t3"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t3i = valori;
                }
                return t3i;
            }
            if (variable.Equals("t4"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t4i = valori;
                }
                return t4i;
            }
            if (variable.Equals("t5"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t5i = valori;
                }
                return t5i;
            }
            if (variable.Equals("t6"))
            {
                if (lstFunciones.Text.Equals("addi"))
                {
                    t6i = valori;
                }
                return t6i;
            }
            return 0;
        }
        private String addi(String funcion, String rd, String rs1, String rs2oInm)
        {
            String binario = "";
            String cadena = "";
            int longitud = 0;
            int numero = Convert.ToInt32(rs2oInm);
            if (numero > 0)
            {
                while (numero > 0)
                {
                    graficos();
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                longitud = cadena.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena;
            }
            asignarVariableGrid(rd, cadena);
            binario += "00000";
            asignarVariableGrid(rs1, "00000");
            binario += "000";
            binario += cadena;
            binario += "0010011";
            return binario;
        }
        private String add(String funcion, String rd, String rs1, String rs2oInm)
        {
            String binario = "";
            String cadena = "";
            String cadena1 = "";
            String cadena2 = "";
            int longitud = 0;
            int numeroRs2oInm = asignarVariable(txtRs2oInm.Text, "0");
            int numeroRs1 = asignarVariable(txtRs1.Text, "0");
            lstFunciones.Text = "addi";
            int numeroRd = asignarVariable(txtRd.Text, Convert.ToString(numeroRs1 + numeroRs2oInm));
            lstFunciones.Text = "add";
            if (numeroRs2oInm > 0)
            {
                while (numeroRs2oInm > 0)
                {
                    if (numeroRs2oInm % 2 == 0)
                    {
                        cadena2 = "0" + cadena2;
                    }
                    else
                    {
                        cadena2 = "1" + cadena2;
                    }
                    numeroRs2oInm = (int)(numeroRs2oInm / 2);
                }
                longitud = cadena2.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena2;
            }
            if (numeroRs1 > 0)
            {
                while (numeroRs1 > 0)
                {
                    if (numeroRs1 % 2 == 0)
                    {
                        cadena1 = "0" + cadena1;
                    }
                    else
                    {
                        cadena1 = "1" + cadena1;
                    }
                    numeroRs1 = (int)(numeroRs1 / 2);
                }
                longitud = cadena1.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena1;
            }
            binario += "000";
            if (numeroRd > 0)
            {
                while (numeroRd > 0)
                {
                    graficos();
                    if (numeroRd % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroRd = (int)(numeroRd / 2);
                }
                longitud = cadena.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena;
            }
            asignarVariableGrid(rd, cadena);
            binario += "0110011";
            return binario;
        }
        private String sub(String funcion, String rd, String rs1, String rs2oInm)
        {
            String binario = "";
            String cadena = "";
            String cadena1 = "";
            String cadena2 = "";
            int longitud = 0;
            int numeroRs2oInm = asignarVariable(txtRs2oInm.Text, "0");
            int numeroRs1 = asignarVariable(txtRs1.Text, "0");
            int numeroRd = 0;
            lstFunciones.Text = "addi";
            if (numeroRs1 > numeroRs2oInm)
            {
                numeroRd = asignarVariable(txtRd.Text, Convert.ToString(numeroRs1 - numeroRs2oInm));
            }
            else {
                numeroRd = asignarVariable(txtRd.Text, Convert.ToString(numeroRs2oInm - numeroRs1));
            }
            lstFunciones.Text = "sub";
            if (numeroRs2oInm > 0)
            {
                while (numeroRs2oInm > 0)
                {
                    if (numeroRs2oInm % 2 == 0)
                    {
                        cadena2 = "0" + cadena2;
                    }
                    else
                    {
                        cadena2 = "1" + cadena2;
                    }
                    numeroRs2oInm = (int)(numeroRs2oInm / 2);
                }
                longitud = cadena2.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena2;
            }
            if (numeroRs1 > 0)
            {
                while (numeroRs1 > 0)
                {
                    if (numeroRs1 % 2 == 0)
                    {
                        cadena1 = "0" + cadena1;
                    }
                    else
                    {
                        cadena1 = "1" + cadena1;
                    }
                    numeroRs1 = (int)(numeroRs1 / 2);
                }
                longitud = cadena1.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena1;
            }
            binario += "000";
            if (numeroRd > 0)
            {
                while (numeroRd > 0)
                {
                    graficos();
                    if (numeroRd % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroRd = (int)(numeroRd / 2);
                }
                longitud = cadena.Length;
                while (longitud < 5)
                {
                    binario += "0";
                    longitud += 1;
                }
                binario += cadena;
            }
            asignarVariableGrid(rd, cadena);
            binario += "0110011";
            return binario;
        }
        private void graficos() {
            Graphics golfgti6;
            golfgti6 = pictureBox1.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 1);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen2 = new Pen(Color.Red, 3);
            Pen blackPen2 = new Pen(Color.Black, 3);
            Thread.Sleep(100);
            golfgti6.DrawRectangle(redPen, 10, 50, 30, 55);
            Thread.Sleep(100);
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            golfgti6.DrawRectangle(blackPen, 10, 50, 30, 55);
            golfgti6.DrawLine(redPen2, 25, 105, 25, 160);
            golfgti6.DrawLine(redPen2, 25, 125, 75, 125);
            golfgti6.DrawEllipse(redPen2, 22, 122, 5, 5);
            golfgti6.DrawLine(redPen2, 74, 126, 74, 45);
            golfgti6.DrawLine(redPen2, 74, 44, 194, 44);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 25, 105, 25, 160);
            golfgti6.DrawLine(blackPen2, 25, 125, 75, 125);
            golfgti6.DrawEllipse(blackPen2, 22, 122, 5, 5);
            golfgti6.DrawLine(blackPen2, 74, 126, 74, 45);
            golfgti6.DrawLine(blackPen2, 74, 44, 194, 44);
            golfgti6.DrawRectangle(redPen, 5, 160, 200, 210);
            golfgti6.DrawLine(redPen, 194, 24, 194, 64);
            golfgti6.DrawLine(redPen, 194, 64, 204, 69);
            golfgti6.DrawLine(redPen, 204, 69, 194, 74);
            golfgti6.DrawLine(redPen, 194, 74, 194, 114);
            golfgti6.DrawLine(redPen, 274, 44, 274, 94);
            golfgti6.DrawLine(redPen, 194, 24, 274, 44);
            golfgti6.DrawLine(redPen, 274, 94, 194, 114);
            golfgti6.DrawLine(redPen2, 174, 94, 194, 94);
            Thread.Sleep(100);
            golfgti6.DrawRectangle(blackPen, 5, 160, 200, 210);
            golfgti6.DrawLine(blackPen, 194, 24, 194, 64);
            golfgti6.DrawLine(blackPen, 194, 64, 204, 69);
            golfgti6.DrawLine(blackPen, 204, 69, 194, 74);
            golfgti6.DrawLine(blackPen, 194, 74, 194, 114);
            golfgti6.DrawLine(blackPen, 274, 44, 274, 94);
            golfgti6.DrawLine(blackPen, 194, 24, 274, 44);
            golfgti6.DrawLine(blackPen, 274, 94, 194, 114);
            golfgti6.DrawLine(blackPen2, 174, 94, 194, 94);
            golfgti6.DrawLine(redPen, 205, 190, 350, 190);
            golfgti6.DrawLine(redPen2, 274, 67, 670, 67);
            golfgti6.DrawEllipse(redPen2, 652, 65, 5, 5);
            golfgti6.DrawLine(redPen2, 655, 67, 655, 30);
            golfgti6.DrawLine(redPen2, 655, 30, 808, 30);
            golfgti6.DrawLine(redPen, 205, 190, 350, 190);
            golfgti6.DrawEllipse(redPen2, 224, 188, 4, 4);
            golfgti6.DrawLine(redPen, 225, 230, 350, 230);
            golfgti6.DrawEllipse(redPen2, 224, 228, 4, 4);
            golfgti6.DrawLine(redPen, 225, 350, 295, 350);
            golfgti6.DrawEllipse(redPen2, 224, 348, 4, 4);
            golfgti6.DrawLine(redPen, 225, 190, 225, 430);
            golfgti6.DrawEllipse(redPen, 290, 240, 30, 120);
            golfgti6.DrawLine(redPen, 270, 230, 270, 270);
            golfgti6.DrawEllipse(redPen2, 268, 228, 4, 4);
            golfgti6.DrawLine(redPen, 270, 270, 290, 270);
            golfgti6.DrawLine(redPen, 320, 305, 350, 305);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawRectangle(redPen, 350, 175, 150, 210);
            golfgti6.DrawLine(redPen, 225, 190, 225, 430);
            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawLine(blackPen2, 274, 67, 670, 67);
            golfgti6.DrawEllipse(blackPen2, 652, 65, 5, 5);
            golfgti6.DrawLine(blackPen2, 655, 67, 655, 30);
            golfgti6.DrawLine(blackPen2, 655, 30, 808, 30);
            golfgti6.DrawLine(blackPen, 205, 190, 350, 190);
            golfgti6.DrawEllipse(blackPen2, 224, 188, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 230, 350, 230);
            golfgti6.DrawEllipse(blackPen2, 224, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 350, 295, 350);
            golfgti6.DrawEllipse(blackPen2, 224, 348, 4, 4);
            golfgti6.DrawLine(blackPen, 225, 190, 225, 430);
            golfgti6.DrawEllipse(blackPen, 290, 240, 30, 120);
            golfgti6.DrawLine(blackPen, 270, 230, 270, 270);
            golfgti6.DrawEllipse(blackPen2, 268, 228, 4, 4);
            golfgti6.DrawLine(blackPen, 270, 270, 290, 270);
            golfgti6.DrawLine(blackPen, 320, 305, 350, 305);
            Thread.Sleep(100);
            golfgti6.DrawRectangle(blackPen, 350, 175, 150, 210);
            golfgti6.DrawLine(blackPen, 225, 190, 225, 430);
            golfgti6.DrawLine(redPen, 225, 430, 430, 430);
            Thread.Sleep(100);
            golfgti6.DrawEllipse(redPen, 430, 400, 60, 60);
            golfgti6.DrawLine(blackPen, 225, 430, 430, 430);
            golfgti6.DrawLine(redPen2, 500, 200, 620, 200);
            golfgti6.DrawLine(redPen2, 500, 245, 560, 245);
            Thread.Sleep(100);
            golfgti6.DrawLine(redPen2, 530, 430, 490, 430);
            golfgti6.DrawEllipse(redPen, 558, 210, 30, 120);
            golfgti6.DrawEllipse(blackPen, 430, 400, 60, 60);
            golfgti6.DrawLine(blackPen2, 500, 200, 620, 200);
            golfgti6.DrawLine(blackPen2, 500, 245, 560, 245);
            golfgti6.DrawEllipse(redPen2, 513, 243, 5, 5);
            golfgti6.DrawLine(redPen2, 515, 245, 515, 380);
            Thread.Sleep(100);
            golfgti6.DrawLine(redPen2, 530, 120, 530, 430);
            golfgti6.DrawLine(redPen2, 620, 260, 588, 260);
            golfgti6.DrawLine(redPen2, 515, 380, 700, 380);
            golfgti6.DrawLine(redPen2, 530, 295, 560, 295);
            golfgti6.DrawEllipse(redPen2, 528, 292, 5, 5);
            golfgti6.DrawLine(redPen, 620, 175, 620, 224);
            golfgti6.DrawLine(redPen, 620, 224, 634, 229);
            golfgti6.DrawLine(redPen, 634, 229, 620, 234);
            golfgti6.DrawLine(redPen, 620, 234, 620, 284);
            golfgti6.DrawLine(redPen, 730, 190, 730, 260);
            golfgti6.DrawLine(redPen, 620, 175, 730, 190);
            golfgti6.DrawLine(redPen, 620, 284, 730, 260);
            golfgti6.DrawLine(redPen, 620, 284, 730, 260);
            golfgti6.DrawLine(blackPen2, 530, 430, 490, 430);
            golfgti6.DrawEllipse(blackPen, 558, 210, 30, 120);
            golfgti6.DrawEllipse(blackPen2, 513, 243, 5, 5);
            golfgti6.DrawLine(blackPen2, 515, 245, 515, 380);
            golfgti6.DrawEllipse(blackPen, 558, 210, 30, 120);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 530, 120, 530, 430);
            golfgti6.DrawLine(blackPen2, 620, 260, 588, 260);
            golfgti6.DrawLine(blackPen2, 515, 380, 700, 380);
            golfgti6.DrawLine(blackPen2, 530, 295, 560, 295);
            golfgti6.DrawEllipse(blackPen2, 528, 292, 5, 5);
            golfgti6.DrawEllipse(redPen, 558, 210, 30, 120);
            golfgti6.DrawLine(blackPen, 620, 175, 620, 224);
            golfgti6.DrawLine(blackPen, 620, 224, 634, 229);
            golfgti6.DrawLine(blackPen, 634, 229, 620, 234);
            golfgti6.DrawLine(blackPen, 620, 234, 620, 284);
            golfgti6.DrawLine(blackPen, 730, 190, 730, 260);
            golfgti6.DrawLine(blackPen, 620, 175, 730, 190);
            golfgti6.DrawLine(blackPen, 620, 284, 730, 260);
            golfgti6.DrawLine(redPen2, 530, 120, 570, 120);
            golfgti6.DrawLine(redPen2, 700, 380, 700, 300);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 530, 120, 570, 120);
            golfgti6.DrawEllipse(blackPen, 558, 210, 30, 120);
            golfgti6.DrawLine(blackPen2, 700, 380, 700, 300);
            golfgti6.DrawEllipse(redPen, 570, 80, 80, 80);
            golfgti6.DrawLine(redPen2, 620, 260, 588, 260);
            Thread.Sleep(100);
            golfgti6.DrawEllipse(blackPen, 570, 80, 80, 80);
            golfgti6.DrawLine(blackPen2, 620, 260, 588, 260);
            golfgti6.DrawLine(redPen2, 650, 120, 670, 120);
            golfgti6.DrawLine(redPen2, 700, 300, 770, 300);
            golfgti6.DrawLine(redPen2, 730, 240, 770, 240);
            golfgti6.DrawEllipse(redPen2, 748, 238, 5, 5);
            golfgti6.DrawLine(redPen2, 750, 210, 750, 385);
            golfgti6.DrawLine(redPen2, 750, 210, 770, 210);
            golfgti6.DrawLine(redPen2, 750, 385, 915, 385);
            golfgti6.DrawLine(redPen2, 915, 285, 935, 285);
            golfgti6.DrawLine(redPen2, 915, 385, 915, 285);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 650, 120, 670, 120);
            golfgti6.DrawLine(blackPen2, 700, 300, 770, 300);
            golfgti6.DrawLine(blackPen2, 730, 240, 770, 240);
            golfgti6.DrawEllipse(blackPen2, 748, 238, 5, 5);
            golfgti6.DrawLine(blackPen2, 750, 210, 750, 385);
            golfgti6.DrawLine(blackPen2, 750, 210, 770, 210);
            golfgti6.DrawLine(blackPen2, 750, 385, 915, 385);
            golfgti6.DrawLine(blackPen2, 915, 285, 935, 285);
            golfgti6.DrawLine(blackPen2, 915, 385, 915, 285);
            golfgti6.DrawLine(redPen2, 890, 205, 935, 205);
            golfgti6.DrawEllipse(redPen, 930, 185, 30, 120);
            golfgti6.DrawLine(redPen, 670, 44, 670, 84);
            golfgti6.DrawLine(redPen, 670, 84, 680, 89);
            golfgti6.DrawLine(redPen, 680, 89, 670, 94);
            golfgti6.DrawLine(redPen, 670, 94, 670, 134);
            golfgti6.DrawLine(redPen, 750, 64, 750, 114);
            golfgti6.DrawLine(redPen, 670, 44, 750, 64);
            golfgti6.DrawLine(redPen, 670, 134, 750, 114);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 890, 205, 935, 205);
            golfgti6.DrawEllipse(blackPen, 930, 185, 30, 120);
            golfgti6.DrawLine(blackPen, 670, 44, 670, 84);
            golfgti6.DrawLine(blackPen, 670, 84, 680, 89);
            golfgti6.DrawLine(blackPen, 680, 89, 670, 94);
            golfgti6.DrawLine(blackPen, 670, 94, 670, 134);
            golfgti6.DrawLine(blackPen, 750, 64, 750, 114);
            golfgti6.DrawLine(blackPen, 670, 44, 750, 64);
            golfgti6.DrawLine(blackPen, 670, 134, 750, 114);
            golfgti6.DrawEllipse(redPen, 800, 20, 30, 120);
            golfgti6.DrawLine(redPen2, 960, 243, 990, 243);
            Thread.Sleep(100);
            golfgti6.DrawEllipse(blackPen, 800, 20, 30, 120);
            golfgti6.DrawLine(blackPen2, 960, 243, 990, 243);
            golfgti6.DrawLine(redPen2, 830, 60, 860, 60);
            golfgti6.DrawLine(redPen2, 990, 243, 990, 483);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 830, 60, 860, 60);
            golfgti6.DrawLine(blackPen2, 990, 243, 990, 483);
            golfgti6.DrawLine(redPen2, 860, 0, 860, 60);
            golfgti6.DrawLine(redPen2, 990, 483, 330, 483);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 860, 0, 860, 60);
            golfgti6.DrawLine(blackPen2, 990, 483, 330, 483);
            golfgti6.DrawLine(redPen2, 25, 0, 860, 0);
            golfgti6.DrawLine(redPen2, 330, 483, 330, 353);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 25, 0, 860, 0);
            golfgti6.DrawLine(blackPen2, 330, 483, 330, 353);
            golfgti6.DrawLine(redPen2, 25, 0, 25, 50);
            golfgti6.DrawLine(redPen2, 330, 353, 350, 353);
            Thread.Sleep(100);
            golfgti6.DrawLine(blackPen2, 25, 0, 25, 50);
            golfgti6.DrawLine(blackPen2, 330, 353, 350, 353);
        }
    }
}
