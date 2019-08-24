        /***************************************************************************************************************\
        * Quantum Design and Engineering (PTY) Ltd
        * 2019-05-17
        *                                    SAVE XML - ROADSIGNS
        *                                    --------------------
        *                              Saves the Roadsigns into XML File
       \***************************************************************************************************************/
        private void SaveXMLRoadSigns()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClassDevices));
            using (FileStream fileStream = new FileStream("RoadSigns1.xml", FileMode.Create))
            {
                serializer.Serialize(fileStream, MyDevices);
                //MyDevices = (ClassDevices)serializer.Deserialize(fileStream);
            }
        }
		