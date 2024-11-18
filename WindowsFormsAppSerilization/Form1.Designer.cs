namespace WindowsFormsAppSerilization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.btnBinaryReader = new System.Windows.Forms.Button();
            this.btnXMLWriter = new System.Windows.Forms.Button();
            this.btnXmlReader = new System.Windows.Forms.Button();
            this.btnSOAPWriter = new System.Windows.Forms.Button();
            this.btnSOAPReader = new System.Windows.Forms.Button();
            this.btnJSONWriter = new System.Windows.Forms.Button();
            this.btnJSONReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(140, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(140, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(140, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 18);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Enter Price";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(262, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(262, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(499, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 46);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryWriter.Location = new System.Drawing.Point(168, 212);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(192, 35);
            this.btnBinaryWriter.TabIndex = 7;
            this.btnBinaryWriter.Text = "Binary Write";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // btnBinaryReader
            // 
            this.btnBinaryReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinaryReader.Location = new System.Drawing.Point(376, 212);
            this.btnBinaryReader.Name = "btnBinaryReader";
            this.btnBinaryReader.Size = new System.Drawing.Size(201, 35);
            this.btnBinaryReader.TabIndex = 8;
            this.btnBinaryReader.Text = "Binary Read";
            this.btnBinaryReader.UseVisualStyleBackColor = true;
            this.btnBinaryReader.Click += new System.EventHandler(this.btnBinaryReader_Click);
            // 
            // btnXMLWriter
            // 
            this.btnXMLWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXMLWriter.Location = new System.Drawing.Point(168, 278);
            this.btnXMLWriter.Name = "btnXMLWriter";
            this.btnXMLWriter.Size = new System.Drawing.Size(192, 35);
            this.btnXMLWriter.TabIndex = 9;
            this.btnXMLWriter.Text = "XML Write";
            this.btnXMLWriter.UseVisualStyleBackColor = true;
            this.btnXMLWriter.Click += new System.EventHandler(this.btnXMLWriter_Click);
            // 
            // btnXmlReader
            // 
            this.btnXmlReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXmlReader.Location = new System.Drawing.Point(376, 278);
            this.btnXmlReader.Name = "btnXmlReader";
            this.btnXmlReader.Size = new System.Drawing.Size(201, 35);
            this.btnXmlReader.TabIndex = 10;
            this.btnXmlReader.Text = "XML Read";
            this.btnXmlReader.UseVisualStyleBackColor = true;
            this.btnXmlReader.Click += new System.EventHandler(this.btnXmlReader_Click);
            // 
            // btnSOAPWriter
            // 
            this.btnSOAPWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPWriter.Location = new System.Drawing.Point(168, 340);
            this.btnSOAPWriter.Name = "btnSOAPWriter";
            this.btnSOAPWriter.Size = new System.Drawing.Size(192, 35);
            this.btnSOAPWriter.TabIndex = 11;
            this.btnSOAPWriter.Text = "SOAP Write";
            this.btnSOAPWriter.UseVisualStyleBackColor = true;
            this.btnSOAPWriter.Click += new System.EventHandler(this.btnSOAPWriter_Click);
            // 
            // btnSOAPReader
            // 
            this.btnSOAPReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOAPReader.Location = new System.Drawing.Point(376, 340);
            this.btnSOAPReader.Name = "btnSOAPReader";
            this.btnSOAPReader.Size = new System.Drawing.Size(201, 35);
            this.btnSOAPReader.TabIndex = 12;
            this.btnSOAPReader.Text = "SOAP Read";
            this.btnSOAPReader.UseVisualStyleBackColor = true;
            this.btnSOAPReader.Click += new System.EventHandler(this.btnSOAPReader_Click);
            // 
            // btnJSONWriter
            // 
            this.btnJSONWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONWriter.Location = new System.Drawing.Point(168, 399);
            this.btnJSONWriter.Name = "btnJSONWriter";
            this.btnJSONWriter.Size = new System.Drawing.Size(192, 35);
            this.btnJSONWriter.TabIndex = 13;
            this.btnJSONWriter.Text = "JSON Write";
            this.btnJSONWriter.UseVisualStyleBackColor = true;
            this.btnJSONWriter.Click += new System.EventHandler(this.btnJSONWriter_Click);
            // 
            // btnJSONReader
            // 
            this.btnJSONReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSONReader.Location = new System.Drawing.Point(376, 399);
            this.btnJSONReader.Name = "btnJSONReader";
            this.btnJSONReader.Size = new System.Drawing.Size(201, 35);
            this.btnJSONReader.TabIndex = 14;
            this.btnJSONReader.Text = "JSON Read";
            this.btnJSONReader.UseVisualStyleBackColor = true;
            this.btnJSONReader.Click += new System.EventHandler(this.btnJSONReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONReader);
            this.Controls.Add(this.btnJSONWriter);
            this.Controls.Add(this.btnSOAPReader);
            this.Controls.Add(this.btnSOAPWriter);
            this.Controls.Add(this.btnXmlReader);
            this.Controls.Add(this.btnXMLWriter);
            this.Controls.Add(this.btnBinaryReader);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "ProductDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnBinaryReader;
        private System.Windows.Forms.Button btnXMLWriter;
        private System.Windows.Forms.Button btnXmlReader;
        private System.Windows.Forms.Button btnSOAPWriter;
        private System.Windows.Forms.Button btnSOAPReader;
        private System.Windows.Forms.Button btnJSONWriter;
        private System.Windows.Forms.Button btnJSONReader;
    }
}

