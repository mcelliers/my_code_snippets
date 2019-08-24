 private void ButtonPing_Click(object sender, EventArgs e)
        {
            String StrAddress = TextIPAddress.Text;
            IPAddress TestUnit = IPAddress.Parse(StrAddress);
            bool _Success = false;

            Ping PingDevice = new Ping();

            PingDevice.PingCompleted += PingDevice_PingCompleted;
            PingReply result = PingDevice.Send(TestUnit);

            switch (result.Status)
            {
                case IPStatus.TimedOut:
                    break;
                case IPStatus.Success:
                    _Success = true;
                    break;
                case IPStatus.BadDestination:
                    break;
                case IPStatus.BadHeader:
                    break;
                case IPStatus.BadOption:
                    break;
                case IPStatus.BadRoute:
                    break;
                case IPStatus.DestinationHostUnreachable:
                    break;
                case IPStatus.DestinationNetworkUnreachable:
                    break;
                case IPStatus.DestinationPortUnreachable:
                    break;
                case IPStatus.DestinationProhibited:
                    break;
                case IPStatus.DestinationScopeMismatch:
                    break;
                case IPStatus.DestinationUnreachable:
                    break;
                case IPStatus.HardwareError:
                    break;
                case IPStatus.IcmpError:
                    break;
                case IPStatus.NoResources:
                    break;
                case IPStatus.PacketTooBig:
                    break;
                case IPStatus.TimeExceeded:
                    break;
                case IPStatus.Unknown:
                    break;
                default:
                    break;
            }

            if (_Success)
            {
                long tm = result.RoundtripTime;
                MessageBox.Show($"Ping Success Roundtrip = {tm}");
            }
            else
            {
                MessageBox.Show($"Ping Error : "  + result.Status.ToString());
            }
            


        }