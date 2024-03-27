
namespace PrawdziwyKalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonplusminus = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.buttonprzecinek = new System.Windows.Forms.Button();
            this.buttonrownosc = new System.Windows.Forms.Button();
            this.buttonjeden = new System.Windows.Forms.Button();
            this.buttondwa = new System.Windows.Forms.Button();
            this.buttontrzy = new System.Windows.Forms.Button();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttoncztery = new System.Windows.Forms.Button();
            this.buttonpiec = new System.Windows.Forms.Button();
            this.buttonszesc = new System.Windows.Forms.Button();
            this.buttonodejmij = new System.Windows.Forms.Button();
            this.buttonsiedem = new System.Windows.Forms.Button();
            this.buttonosiem = new System.Windows.Forms.Button();
            this.buttondziewiec = new System.Windows.Forms.Button();
            this.buttonmnoz = new System.Windows.Forms.Button();
            this.buttonulamek = new System.Windows.Forms.Button();
            this.buttonpow = new System.Windows.Forms.Button();
            this.buttonsqrt = new System.Windows.Forms.Button();
            this.buttondziel = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttoncofnij = new System.Windows.Forms.Button();
            this.textBoxwynik = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonplusminus
            // 
            this.buttonplusminus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonplusminus.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonplusminus.Location = new System.Drawing.Point(3, 436);
            this.buttonplusminus.Name = "buttonplusminus";
            this.buttonplusminus.Size = new System.Drawing.Size(80, 55);
            this.buttonplusminus.TabIndex = 0;
            this.buttonplusminus.Text = "+/-";
            this.buttonplusminus.UseVisualStyleBackColor = false;
            this.buttonplusminus.Click += new System.EventHandler(this.buttonop_Click);
            // 
            // buttonzero
            // 
            this.buttonzero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonzero.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonzero.Location = new System.Drawing.Point(89, 436);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(80, 55);
            this.buttonzero.TabIndex = 1;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = false;
            this.buttonzero.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonprzecinek
            // 
            this.buttonprzecinek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonprzecinek.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonprzecinek.Location = new System.Drawing.Point(175, 436);
            this.buttonprzecinek.Name = "buttonprzecinek";
            this.buttonprzecinek.Size = new System.Drawing.Size(80, 55);
            this.buttonprzecinek.TabIndex = 2;
            this.buttonprzecinek.Text = ",";
            this.buttonprzecinek.UseVisualStyleBackColor = false;
            this.buttonprzecinek.Click += new System.EventHandler(this.button_Click2);
            // 
            // buttonrownosc
            // 
            this.buttonrownosc.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonrownosc.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonrownosc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonrownosc.Location = new System.Drawing.Point(261, 436);
            this.buttonrownosc.Name = "buttonrownosc";
            this.buttonrownosc.Size = new System.Drawing.Size(80, 55);
            this.buttonrownosc.TabIndex = 3;
            this.buttonrownosc.Text = "=";
            this.buttonrownosc.UseVisualStyleBackColor = false;
            this.buttonrownosc.Click += new System.EventHandler(this.buttonrownosc_Click);
            // 
            // buttonjeden
            // 
            this.buttonjeden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonjeden.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonjeden.Location = new System.Drawing.Point(3, 375);
            this.buttonjeden.Name = "buttonjeden";
            this.buttonjeden.Size = new System.Drawing.Size(80, 55);
            this.buttonjeden.TabIndex = 4;
            this.buttonjeden.Text = "1";
            this.buttonjeden.UseVisualStyleBackColor = false;
            this.buttonjeden.Click += new System.EventHandler(this.button_Click);
            // 
            // buttondwa
            // 
            this.buttondwa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondwa.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondwa.Location = new System.Drawing.Point(89, 375);
            this.buttondwa.Name = "buttondwa";
            this.buttondwa.Size = new System.Drawing.Size(80, 55);
            this.buttondwa.TabIndex = 5;
            this.buttondwa.Text = "2";
            this.buttondwa.UseVisualStyleBackColor = false;
            this.buttondwa.Click += new System.EventHandler(this.button_Click);
            // 
            // buttontrzy
            // 
            this.buttontrzy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttontrzy.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttontrzy.Location = new System.Drawing.Point(175, 375);
            this.buttontrzy.Name = "buttontrzy";
            this.buttontrzy.Size = new System.Drawing.Size(80, 55);
            this.buttontrzy.TabIndex = 6;
            this.buttontrzy.Text = "3";
            this.buttontrzy.UseVisualStyleBackColor = false;
            this.buttontrzy.Click += new System.EventHandler(this.button_Click);
            // 
            // buttondodaj
            // 
            this.buttondodaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttondodaj.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondodaj.Location = new System.Drawing.Point(261, 375);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(80, 55);
            this.buttondodaj.TabIndex = 7;
            this.buttondodaj.Text = "+";
            this.buttondodaj.UseVisualStyleBackColor = false;
            this.buttondodaj.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttoncztery
            // 
            this.buttoncztery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoncztery.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttoncztery.Location = new System.Drawing.Point(3, 314);
            this.buttoncztery.Name = "buttoncztery";
            this.buttoncztery.Size = new System.Drawing.Size(80, 55);
            this.buttoncztery.TabIndex = 8;
            this.buttoncztery.Text = "4";
            this.buttoncztery.UseVisualStyleBackColor = false;
            this.buttoncztery.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonpiec
            // 
            this.buttonpiec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonpiec.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonpiec.Location = new System.Drawing.Point(89, 314);
            this.buttonpiec.Name = "buttonpiec";
            this.buttonpiec.Size = new System.Drawing.Size(80, 55);
            this.buttonpiec.TabIndex = 9;
            this.buttonpiec.Text = "5";
            this.buttonpiec.UseVisualStyleBackColor = false;
            this.buttonpiec.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonszesc
            // 
            this.buttonszesc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonszesc.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonszesc.Location = new System.Drawing.Point(175, 314);
            this.buttonszesc.Name = "buttonszesc";
            this.buttonszesc.Size = new System.Drawing.Size(80, 55);
            this.buttonszesc.TabIndex = 10;
            this.buttonszesc.Text = "6";
            this.buttonszesc.UseVisualStyleBackColor = false;
            this.buttonszesc.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonodejmij
            // 
            this.buttonodejmij.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonodejmij.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonodejmij.Location = new System.Drawing.Point(261, 314);
            this.buttonodejmij.Name = "buttonodejmij";
            this.buttonodejmij.Size = new System.Drawing.Size(80, 55);
            this.buttonodejmij.TabIndex = 11;
            this.buttonodejmij.Text = "-";
            this.buttonodejmij.UseVisualStyleBackColor = false;
            this.buttonodejmij.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonsiedem
            // 
            this.buttonsiedem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsiedem.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonsiedem.Location = new System.Drawing.Point(3, 253);
            this.buttonsiedem.Name = "buttonsiedem";
            this.buttonsiedem.Size = new System.Drawing.Size(80, 55);
            this.buttonsiedem.TabIndex = 12;
            this.buttonsiedem.Text = "7";
            this.buttonsiedem.UseVisualStyleBackColor = false;
            this.buttonsiedem.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonosiem
            // 
            this.buttonosiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonosiem.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonosiem.Location = new System.Drawing.Point(89, 253);
            this.buttonosiem.Name = "buttonosiem";
            this.buttonosiem.Size = new System.Drawing.Size(80, 55);
            this.buttonosiem.TabIndex = 13;
            this.buttonosiem.Text = "8";
            this.buttonosiem.UseVisualStyleBackColor = false;
            this.buttonosiem.Click += new System.EventHandler(this.button_Click);
            // 
            // buttondziewiec
            // 
            this.buttondziewiec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondziewiec.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondziewiec.Location = new System.Drawing.Point(175, 253);
            this.buttondziewiec.Name = "buttondziewiec";
            this.buttondziewiec.Size = new System.Drawing.Size(80, 55);
            this.buttondziewiec.TabIndex = 14;
            this.buttondziewiec.Text = "9";
            this.buttondziewiec.UseVisualStyleBackColor = false;
            this.buttondziewiec.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonmnoz
            // 
            this.buttonmnoz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonmnoz.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonmnoz.Location = new System.Drawing.Point(261, 253);
            this.buttonmnoz.Name = "buttonmnoz";
            this.buttonmnoz.Size = new System.Drawing.Size(80, 55);
            this.buttonmnoz.TabIndex = 15;
            this.buttonmnoz.Text = "*";
            this.buttonmnoz.UseVisualStyleBackColor = false;
            this.buttonmnoz.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonulamek
            // 
            this.buttonulamek.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonulamek.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonulamek.Location = new System.Drawing.Point(3, 192);
            this.buttonulamek.Name = "buttonulamek";
            this.buttonulamek.Size = new System.Drawing.Size(80, 55);
            this.buttonulamek.TabIndex = 16;
            this.buttonulamek.Text = "1/x";
            this.buttonulamek.UseVisualStyleBackColor = false;
            this.buttonulamek.Click += new System.EventHandler(this.buttonop_Click);
            // 
            // buttonpow
            // 
            this.buttonpow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonpow.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonpow.Location = new System.Drawing.Point(89, 192);
            this.buttonpow.Name = "buttonpow";
            this.buttonpow.Size = new System.Drawing.Size(80, 55);
            this.buttonpow.TabIndex = 17;
            this.buttonpow.Text = "x^2";
            this.buttonpow.UseVisualStyleBackColor = false;
            this.buttonpow.Click += new System.EventHandler(this.buttonop_Click);
            // 
            // buttonsqrt
            // 
            this.buttonsqrt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonsqrt.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonsqrt.Location = new System.Drawing.Point(175, 192);
            this.buttonsqrt.Name = "buttonsqrt";
            this.buttonsqrt.Size = new System.Drawing.Size(80, 55);
            this.buttonsqrt.TabIndex = 18;
            this.buttonsqrt.Text = "sqrt";
            this.buttonsqrt.UseVisualStyleBackColor = false;
            this.buttonsqrt.Click += new System.EventHandler(this.buttonop_Click);
            // 
            // buttondziel
            // 
            this.buttondziel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttondziel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondziel.Location = new System.Drawing.Point(261, 192);
            this.buttondziel.Name = "buttondziel";
            this.buttondziel.Size = new System.Drawing.Size(80, 55);
            this.buttondziel.TabIndex = 19;
            this.buttondziel.Text = "÷";
            this.buttondziel.UseVisualStyleBackColor = false;
            this.buttondziel.Click += new System.EventHandler(this.operator_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.Location = new System.Drawing.Point(3, 131);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 55);
            this.button20.TabIndex = 20;
            this.button20.Text = "%";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCE.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCE.Location = new System.Drawing.Point(89, 131);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(80, 55);
            this.buttonCE.TabIndex = 21;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonC.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.Location = new System.Drawing.Point(175, 131);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(80, 55);
            this.buttonC.TabIndex = 22;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttoncofnij
            // 
            this.buttoncofnij.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoncofnij.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttoncofnij.Location = new System.Drawing.Point(261, 131);
            this.buttoncofnij.Name = "buttoncofnij";
            this.buttoncofnij.Size = new System.Drawing.Size(80, 55);
            this.buttoncofnij.TabIndex = 23;
            this.buttoncofnij.Text = " ⬅";
            this.buttoncofnij.UseVisualStyleBackColor = false;
            this.buttoncofnij.Click += new System.EventHandler(this.buttoncofnij_Click);
            // 
            // textBoxwynik
            // 
            this.textBoxwynik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxwynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxwynik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxwynik.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxwynik.Location = new System.Drawing.Point(3, 70);
            this.textBoxwynik.Name = "textBoxwynik";
            this.textBoxwynik.ReadOnly = true;
            this.textBoxwynik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxwynik.Size = new System.Drawing.Size(338, 55);
            this.textBoxwynik.TabIndex = 24;
            this.textBoxwynik.Text = "0";
            this.textBoxwynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.DimGray;
            this.label.Location = new System.Drawing.Point(12, 34);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label.Size = new System.Drawing.Size(0, 33);
            this.label.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(347, 503);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxwynik);
            this.Controls.Add(this.buttoncofnij);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.buttondziel);
            this.Controls.Add(this.buttonsqrt);
            this.Controls.Add(this.buttonpow);
            this.Controls.Add(this.buttonulamek);
            this.Controls.Add(this.buttonmnoz);
            this.Controls.Add(this.buttondziewiec);
            this.Controls.Add(this.buttonosiem);
            this.Controls.Add(this.buttonsiedem);
            this.Controls.Add(this.buttonodejmij);
            this.Controls.Add(this.buttonszesc);
            this.Controls.Add(this.buttonpiec);
            this.Controls.Add(this.buttoncztery);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.buttontrzy);
            this.Controls.Add(this.buttondwa);
            this.Controls.Add(this.buttonjeden);
            this.Controls.Add(this.buttonrownosc);
            this.Controls.Add(this.buttonprzecinek);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttonplusminus);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonplusminus;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.Button buttonprzecinek;
        private System.Windows.Forms.Button buttonrownosc;
        private System.Windows.Forms.Button buttonjeden;
        private System.Windows.Forms.Button buttondwa;
        private System.Windows.Forms.Button buttontrzy;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttoncztery;
        private System.Windows.Forms.Button buttonpiec;
        private System.Windows.Forms.Button buttonszesc;
        private System.Windows.Forms.Button buttonodejmij;
        private System.Windows.Forms.Button buttonsiedem;
        private System.Windows.Forms.Button buttonosiem;
        private System.Windows.Forms.Button buttondziewiec;
        private System.Windows.Forms.Button buttonmnoz;
        private System.Windows.Forms.Button buttonulamek;
        private System.Windows.Forms.Button buttonpow;
        private System.Windows.Forms.Button buttonsqrt;
        private System.Windows.Forms.Button buttondziel;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttoncofnij;
        private System.Windows.Forms.TextBox textBoxwynik;
        private System.Windows.Forms.Label label;
    }
}

