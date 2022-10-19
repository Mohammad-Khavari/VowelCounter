
namespace VowelCounter
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.txtContent = new System.Windows.Forms.TextBox();
      this.chkUseDoevents = new System.Windows.Forms.CheckBox();
      this.chkUseBackground = new System.Windows.Forms.CheckBox();
      this.brnStart = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txtA = new System.Windows.Forms.TextBox();
      this.txtE = new System.Windows.Forms.TextBox();
      this.txtI = new System.Windows.Forms.TextBox();
      this.txtO = new System.Windows.Forms.TextBox();
      this.txtU = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.progressB = new System.Windows.Forms.ProgressBar();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblEvtCompete = new System.Windows.Forms.Label();
      this.BckThread = new System.ComponentModel.BackgroundWorker();
      this.SuspendLayout();
      // 
      // txtContent
      // 
      this.txtContent.Location = new System.Drawing.Point(12, 109);
      this.txtContent.Multiline = true;
      this.txtContent.Name = "txtContent";
      this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtContent.Size = new System.Drawing.Size(586, 226);
      this.txtContent.TabIndex = 0;
      this.txtContent.Text = resources.GetString("txtContent.Text");
      // 
      // chkUseDoevents
      // 
      this.chkUseDoevents.AutoSize = true;
      this.chkUseDoevents.Location = new System.Drawing.Point(12, 53);
      this.chkUseDoevents.Name = "chkUseDoevents";
      this.chkUseDoevents.Size = new System.Drawing.Size(78, 17);
      this.chkUseDoevents.TabIndex = 1;
      this.chkUseDoevents.Text = "Use DoEvt";
      this.chkUseDoevents.UseVisualStyleBackColor = true;
      // 
      // chkUseBackground
      // 
      this.chkUseBackground.AutoSize = true;
      this.chkUseBackground.Location = new System.Drawing.Point(12, 30);
      this.chkUseBackground.Name = "chkUseBackground";
      this.chkUseBackground.Size = new System.Drawing.Size(144, 17);
      this.chkUseBackground.TabIndex = 2;
      this.chkUseBackground.Text = "Use Background Worker";
      this.chkUseBackground.UseVisualStyleBackColor = true;
      this.chkUseBackground.CheckedChanged += new System.EventHandler(this.chkUseBackground_CheckedChanged);
      // 
      // brnStart
      // 
      this.brnStart.Location = new System.Drawing.Point(523, 12);
      this.brnStart.Name = "brnStart";
      this.brnStart.Size = new System.Drawing.Size(75, 23);
      this.brnStart.TabIndex = 3;
      this.brnStart.Text = "Start";
      this.brnStart.UseVisualStyleBackColor = true;
      this.brnStart.Click += new System.EventHandler(this.brnStart_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(523, 41);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // txtA
      // 
      this.txtA.Location = new System.Drawing.Point(12, 399);
      this.txtA.Name = "txtA";
      this.txtA.Size = new System.Drawing.Size(61, 20);
      this.txtA.TabIndex = 4;
      // 
      // txtE
      // 
      this.txtE.Location = new System.Drawing.Point(143, 399);
      this.txtE.Name = "txtE";
      this.txtE.Size = new System.Drawing.Size(61, 20);
      this.txtE.TabIndex = 4;
      // 
      // txtI
      // 
      this.txtI.Location = new System.Drawing.Point(265, 399);
      this.txtI.Name = "txtI";
      this.txtI.Size = new System.Drawing.Size(61, 20);
      this.txtI.TabIndex = 4;
      // 
      // txtO
      // 
      this.txtO.Location = new System.Drawing.Point(395, 399);
      this.txtO.Name = "txtO";
      this.txtO.Size = new System.Drawing.Size(61, 20);
      this.txtO.TabIndex = 4;
      // 
      // txtU
      // 
      this.txtU.Location = new System.Drawing.Point(537, 399);
      this.txtU.Name = "txtU";
      this.txtU.Size = new System.Drawing.Size(61, 20);
      this.txtU.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(33, 379);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "A";
      // 
      // progressB
      // 
      this.progressB.Location = new System.Drawing.Point(12, 435);
      this.progressB.Name = "progressB";
      this.progressB.Size = new System.Drawing.Size(586, 23);
      this.progressB.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(163, 379);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(18, 17);
      this.label2.TabIndex = 5;
      this.label2.Text = "E";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(288, 379);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(12, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "I";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(419, 379);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(20, 17);
      this.label4.TabIndex = 5;
      this.label4.Text = "O";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(562, 379);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(19, 17);
      this.label5.TabIndex = 5;
      this.label5.Text = "U";
      // 
      // lblEvtCompete
      // 
      this.lblEvtCompete.AutoSize = true;
      this.lblEvtCompete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEvtCompete.Location = new System.Drawing.Point(12, 86);
      this.lblEvtCompete.Name = "lblEvtCompete";
      this.lblEvtCompete.Size = new System.Drawing.Size(85, 20);
      this.lblEvtCompete.TabIndex = 7;
      this.lblEvtCompete.Text = "Complete";
      // 
      // BckThread
      // 
      this.BckThread.WorkerReportsProgress = true;
      this.BckThread.WorkerSupportsCancellation = true;
      this.BckThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BckThread_DoWork);
      this.BckThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BckThread_ProgressChanged);
      this.BckThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BckThread_RunWorkerCompleted);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(610, 476);
      this.Controls.Add(this.lblEvtCompete);
      this.Controls.Add(this.progressB);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtU);
      this.Controls.Add(this.txtO);
      this.Controls.Add(this.txtI);
      this.Controls.Add(this.txtE);
      this.Controls.Add(this.txtA);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.brnStart);
      this.Controls.Add(this.chkUseBackground);
      this.Controls.Add(this.chkUseDoevents);
      this.Controls.Add(this.txtContent);
      this.Name = "Form1";
      this.Text = "Vowel Counter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtContent;
    private System.Windows.Forms.CheckBox chkUseDoevents;
    private System.Windows.Forms.CheckBox chkUseBackground;
    private System.Windows.Forms.Button brnStart;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.TextBox txtE;
    private System.Windows.Forms.TextBox txtI;
    private System.Windows.Forms.TextBox txtO;
    private System.Windows.Forms.TextBox txtU;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ProgressBar progressB;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblEvtCompete;
    private System.ComponentModel.BackgroundWorker BckThread;
  }
}

