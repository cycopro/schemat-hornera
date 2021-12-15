
namespace schemat_hornera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.podstawa = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.liczba = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // podstawa
            // 
            this.podstawa.Location = new System.Drawing.Point(17, 36);
            this.podstawa.Name = "podstawa";
            this.podstawa.Size = new System.Drawing.Size(132, 22);
            this.podstawa.TabIndex = 0;
            this.podstawa.Text = "podstawa(2...16)";
            this.podstawa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // liczba
            // 
            this.liczba.Location = new System.Drawing.Point(17, 64);
            this.liczba.Name = "liczba";
            this.liczba.Size = new System.Drawing.Size(132, 22);
            this.liczba.TabIndex = 1;
            this.liczba.Text = "liczba";
            this.liczba.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox2_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "przelicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(17, 114);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(132, 22);
            this.wynik.TabIndex = 3;
            this.wynik.Text = "wynik(10)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 173);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liczba);
            this.Controls.Add(this.podstawa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "schemat hornera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox podstawa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox liczba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wynik;
    }
}

