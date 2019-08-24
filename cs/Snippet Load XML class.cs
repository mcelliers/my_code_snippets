        /***************************************************************************************************************\
        * Quantum Design and Engineering (PTY) Ltd
        * 2019-05-17
        *                                    LOAD XML - ROADSIGNS
        *                                    --------------------
        *                              Loads the XML File into the Devices list
       \***************************************************************************************************************/

        private void LoadXMLRoadSigns()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClassDevices));
            using (FileStream fileStream = new FileStream("RoadSigns1.xml", FileMode.Open))
            {
                MyDevices = (ClassDevices)serializer.Deserialize(fileStream);
            }

            ListRoadSigns.DataSource = MyDevices.RoadSigns;
            
        }
		