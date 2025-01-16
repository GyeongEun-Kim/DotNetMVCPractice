using Microsoft.AspNetCore.Mvc;
using BusinessLayer.DTO;
using BusinessLayer.Services;

namespace CRUDProject.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService memberService;

        public MemberController(MemberServiceUsingMemory memberService)
        {
            this.memberService = memberService;
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(MemberDTO member)
        {
            memberService.Add(member);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var member = memberService.GetById(id);
            return View(member);
        }

        public IActionResult Edit(int id)
        {
            var member = memberService.GetById(id);
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(int id, MemberDTO member)
        {
            memberService.Update(member);
            return RedirectToAction(nameof(Index)); 

        }

        public IActionResult Index()
        {
            var members = memberService.GetAll(); 
            return View(members); 
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var member = memberService.GetById(id);
            memberService.Delete(id); 
            return RedirectToAction("Index"); 
        }
    }
}
