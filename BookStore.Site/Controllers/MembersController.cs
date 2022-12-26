﻿using BookStore.Site.Models.Infrastructures.Repositories;
using BookStore.Site.Models.Infrastructures.Services;
using BookStore.Site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Site.Controllers
{
    public class MembersController : Controller
    {
        private IMemberRepository repository = new MemberRepository();

        // GET: Members
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = new MemberService(repository);

            (bool IsSucess, string ErrorMessage) response = service.CreateNewMember(model.ToRequestDto());

            if (response.IsSucess)
            {
                //建檔成功，轉到confirm page
                return View("RegisterConfirm");
            }
            else
            {
                ModelState.AddModelError(string.Empty, response.ErrorMessage);
                return View(model);
            }
        }

        public ActionResult ActiveRegister(int memberId, string confirmCode)
        {
            IMemberRepository repo = new MemberRepository(); ;
            var service = new MemberService(repo);
            service.ActiveRegister(memberId, confirmCode);  

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}