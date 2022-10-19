using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace VowelCounter
{
  public partial class Form1 : Form
  {
    private bool cancel_work = false;
    private long count_a, count_e, count_i, count_o, count_u;

    public Form1()
    {
      InitializeComponent();
    }

    private void CheckVowelA(char c)
    {
      long Vowel_count;
      if (c == 'A' || c == 'a')
      {
        if (chkUseBackground.CheckState != CheckState.Checked)
        {
          long.TryParse(txtA.Text, out Vowel_count);
          Vowel_count++;
          txtA.Text = Vowel_count.ToString();
        }
        else
        {
          count_a = count_a + 1;
        }
      }
    }

    private void CheckVowelE(char c)
    {
      long Vowel_count;
      if (c == 'E' || c == 'e')
      {
        if (chkUseBackground.CheckState != CheckState.Checked)
        {
          long.TryParse(txtE.Text, out Vowel_count);
          Vowel_count++;
          txtE.Text = Vowel_count.ToString();
        }
        else
          count_e = count_e + 1;
      }
    }

    private void CheckVowelI(char c)
    {
      long Vowel_count;
      if (c == 'I' || c == 'i')
      {
        if (chkUseBackground.CheckState != CheckState.Checked)
        {
          long.TryParse(txtI.Text, out Vowel_count);
          Vowel_count++;
          txtI.Text = Vowel_count.ToString();
        }
        else
          count_i = count_i + 1;
      }
    }

    private void CheckVowelO(char c)
    {
      long Vowel_count;
      if (c == 'O' || c == 'o')
      {
        if (chkUseBackground.CheckState != CheckState.Checked)
        {
          long.TryParse(txtO.Text, out Vowel_count);
          Vowel_count++;
          txtO.Text = Vowel_count.ToString();
        }
        else
          count_o = count_o + 1;
      }
    }

    private void CheckVowelU(char c)
    {
      long Vowel_count;
      if (c == 'U' || c == 'u')
      {
        if (chkUseBackground.CheckState != CheckState.Checked)
        {
          long.TryParse(txtU.Text, out Vowel_count);
          Vowel_count++;
          txtU.Text = Vowel_count.ToString();
        }
        else
          count_u = count_u + 1;
      }
    }

    private void brnStart_Click(object sender, EventArgs e)
    {
      cancel_work = false;
      //progressB.Value = 0;
      count_a = 0;
      count_e = 0;
      count_i = 0;
      count_o = 0;
      count_u = 0;
      txtA.Text = "0";
      txtE.Text = "0";
      txtI.Text = "0";
      txtO.Text = "0";
      txtU.Text = "0";

      if (chkUseBackground.CheckState != CheckState.Checked)
      {
        DoWithoutBKGrd();
      }
      else
      {
        BckThread.RunWorkerAsync();
      }
    }

    private void DoWithoutBKGrd()
    {
      string strcontent = txtContent.Text;
      long len = strcontent.Length;
      int Prog_Inc = (int)(len / 100);
     
      char[] chars = strcontent.ToCharArray();

      for (int itr = 0; itr < len; itr++)
      {
        if (cancel_work == false)
        {
          char c = chars[itr];
          lblEvtCompete.Text = "Count In-progress...";

          CheckVowelA(c);
          CheckVowelE(c);
          CheckVowelI(c);
          CheckVowelO(c);
          CheckVowelU(c);

          int prog_value = (itr / Prog_Inc);
          if (prog_value > 100)
          {
            prog_value = 100;
            progressB.Value = prog_value;
            Thread.Sleep(10);
          }
          if(chkUseDoevents.CheckState != CheckState.Checked)
          {
            Application.DoEvents();
          }
        }
        else
        {
          txtA.Text = "0";
          txtE.Text = "0";
          txtI.Text = "0";
          txtO.Text = "0";
          txtU.Text = "0";
          lblEvtCompete.Text = "Counts canceled";
        }
      }
      lblEvtCompete.Text = "Vowels counted";
    }

    private void chkUseBackground_CheckedChanged(object sender, EventArgs e)
    {
      if(chkUseBackground.CheckState == CheckState.Checked)
      {
        chkUseDoevents.Enabled = false;
        chkUseDoevents.CheckState = CheckState.Unchecked;
      }
      else
      {
        chkUseDoevents.Enabled = true;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      cancel_work = true;
      if (chkUseBackground.CheckState == CheckState.Checked)
      {
        BckThread.CancelAsync();
      }
      
    }

    private void BckThread_DoWork(object sender, DoWorkEventArgs e)
    {
      string strcontent = txtContent.Text;
      long len = strcontent.Length;
      int Prog_Inc = (int)(len / 100);

      char[] chars = strcontent.ToCharArray();

      for(int itr =0; itr <len; itr++)
      {
        char c = chars[itr];
        if (BckThread.CancellationPending == true)
        {
          e.Cancel = true;
          return;
        }

        CheckVowelA(c);
        CheckVowelE(c);
        CheckVowelI(c);
        CheckVowelO(c);
        CheckVowelU(c);

        int prog_value = (itr / Prog_Inc);
        if (prog_value > 100)
          prog_value = 100;
        BckThread.ReportProgress(prog_value);
        Thread.Sleep(5);
      }

    }

    private void BckThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressB.Value = e.ProgressPercentage;
      txtA.Text = count_a.ToString();
      txtE.Text = count_e.ToString();
      txtI.Text = count_i.ToString();
      txtO.Text = count_o.ToString();
      txtU.Text = count_u.ToString();
    }

    private void BckThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if(e.Cancelled == true)
      {
        lblEvtCompete.Text = "Canceled";
      }
      else
      {
        lblEvtCompete.Text = "Completed";
      }
    }
  }
}