using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement_Assignment.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime EntryDate { get; set; }
        public Member Member { get; set; }
        public Equipment()
        {
            Member = new Member();
        }

        public static List<Equipment> LstEquipment()
        {

            List<Equipment> equipmentList = new List<Equipment>();


            for (int i = 1; i < 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Computer " + i.ToString();
                equipment.Count = i * 5;
                equipment.EntryDate = DateTime.Now.Date;
                equipmentList.Add(equipment);
            }

            return equipmentList;
        }


        public static List<Equipment> LstAssignedEquipment()
        {

            List<Equipment> equipmentList = new List<Equipment>();


            for (int i = 1; i < 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Computer " + i.ToString();
                equipment.Member.MemberName = "Member " + i.ToString();
                equipment.Member.MobileNumber = "01721178207";
                equipmentList.Add(equipment);
            }

            return equipmentList;
        }
    }
}