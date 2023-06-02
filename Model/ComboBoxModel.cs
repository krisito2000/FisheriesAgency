using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Model
{
    public class ComboBoxModel
    {
        public class ComboBoxOwner
        {
            public int OwnerId { get; set; }
            public string Name { get; set; }

            public ComboBoxOwner(string name, int ownerId)
            {
                Name = name;
                OwnerId = ownerId;
            }
            public override string ToString()
            {
                return Name;
            }
        }
    }
    public class ComboBoxCaptain
    {
        public int CaptainId { get; set; }
        public string Name { get; set; }

        public ComboBoxCaptain(string name, int captainId)
        {
            Name = name;
            CaptainId = captainId;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class ComboBoxVessel
    {
        public int VesselId { get; set; }
        public string InternationalNumber { get; set; }

        public ComboBoxVessel(string internationalNumber, int vesselId)
        {
            InternationalNumber = internationalNumber;
            VesselId = vesselId;
        }

        public override string ToString()
        {
            return InternationalNumber;
        }
    }
    public class ComboBoxMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public ComboBoxMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    public class ComboBoxTrip
    {
        public int TripId { get; set; }
        public int VesselId { get; set; }

        public ComboBoxTrip(int tripId, int vesselId)
        {
            TripId = tripId;
            VesselId = vesselId;
        }

        public override string ToString()
        {
            return VesselId.ToString();
        }
    }
}
