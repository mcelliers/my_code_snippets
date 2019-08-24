 private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.None:
                    break;
            }