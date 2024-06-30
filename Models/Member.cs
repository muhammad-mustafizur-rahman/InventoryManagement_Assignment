using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement_Assignment.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberDesignation { get; set; }
        public string MobileNumber { get; set; }


        public static List<Member> LstMember()
        {

            List<Member> memberList = new List<Member>();


            for (int i = 1; i < 30; i++)
            {
                Member member = new Member();
                member.MemberName = "Member " + i.ToString();
                member.MemberDesignation = "Software Eng";
                member.MobileNumber = "017211782"+ i;
                memberList.Add(member);
            }

            return memberList;
        }

    }
}