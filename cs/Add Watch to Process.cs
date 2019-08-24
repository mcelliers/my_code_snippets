/********************************************************************\
*			Measure the Time it takes to Execute A process
*
*
\********************************************************************/
var watch = System.Diagnostics.Stopwatch.StartNew();
/* DO PROCESS HERE */
watch.Stop();
long _ExecutionTime = watch.ElapsedMilliseconds;