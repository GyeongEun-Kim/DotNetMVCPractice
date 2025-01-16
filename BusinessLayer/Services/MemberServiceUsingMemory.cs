using System.Collections.Generic;
using System.Linq;
using BusinessLayer.DTO;

namespace BusinessLayer.Services
{
    public class MemberServiceUsingMemory : IMemberService
    {
        private readonly List<MemberDTO> members = new List<MemberDTO>(); //메모리에 저장
        private int nextId = 1;

        public List<MemberDTO> GetAll()
        {
            return members;
        }

        public MemberDTO GetById(int id)
        {
            return members.Find(member => member.Id == id);
        }

        public void Add(MemberDTO member)
        {
            member.Id = nextId++;
            member.CreDateTime = DateTime.Now;
            members.Add(member);
        }

        public void Delete(int id)
        {
            var member = members.Find(member => member.Id == id);
            members.Remove(member);

        }


        public void Update(MemberDTO updatedMember)
        {
            var existingMember = members.Find(member => member.Id == updatedMember.Id);

            existingMember.Company = updatedMember.Company;
            existingMember.Grade = updatedMember.Grade;
            existingMember.Name = updatedMember.Name;
            existingMember.Age = updatedMember.Age;
            existingMember.ModDateTime = DateTime.Now; 

        }
    }
}
