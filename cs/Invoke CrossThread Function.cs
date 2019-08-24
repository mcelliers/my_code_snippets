/********************************************************************\
*			Call A Function from another Thread
*
*
\********************************************************************/

 SetScadaExecutionValue(SE.ExecutionTime.ToString());

/********************************************************************\
*			The Function
*
\********************************************************************/
private delegate void ScadaExecutionValueCallback(string TextMessage);
// ScadaExecutionValueCallback d = new ScadaExecutionValueCallback(setScadaExecutionValue);
// this.Invoke(d, new object[] { TextMessage });
private void SetScadaExecutionValue(string Value)
{
	if (this.InvokeRequired)
	{
		ScadaExecutionValueCallback d = new ScadaExecutionValueCallback(SetScadaExecutionValue);
		this.Invoke(d, new object[] { Value });

	}
	else
	{
		labelSCADAExecutionTime.Text = SE.ExecutionTime.ToString();
		LabelScadaMode.Text = $"Mode: {SCADA1.ServerMode.ToString()}"; 
	}
}