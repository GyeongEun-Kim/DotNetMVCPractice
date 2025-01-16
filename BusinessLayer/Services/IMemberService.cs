using BusinessLayer.DTO;

namespace BusinessLayer.Services
{
    public interface IMemberService
    {
        public List<MemberDTO> GetAll();

        public MemberDTO GetById(int id);

        public void Add(MemberDTO member);
        public void Delete(int id);

        public void Update(MemberDTO updatedMember);
    }
}


