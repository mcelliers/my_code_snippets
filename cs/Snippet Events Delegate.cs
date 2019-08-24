/*************************************************************\
					Dot Net Standard Guidelines
							Events
\*************************************************************/
        //Events
        public delegate void EventHandler(object sender, EventArgs e);  //Dot.Net Standard Guidelines
        public event EventHandler OnError;
		
//ToDo Raise an Event		
		EventArgs e = new EventArgs();
        OnError?.Invoke(this, e);
		
/*************************************************************\
					Events With Parameters
							Events
\*************************************************************/

        public delegate void StatusReceivedHandler(string receivedStatus);
        public event StatusReceivedHandler OnStatusReceived;
		
//To Raise Event - Add this to your Function
		OnStatusReceived?.Invoke("Connection Error");
		 


		 
		 