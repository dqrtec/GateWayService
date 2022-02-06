using System;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class SessionController : ControllerBase{

    SessionController(){
    }

    [HttpPost(Name = "NewLogin")]
    string NewLogin(){
        string NewSession = "";
        return NewSession;
    }

    [HttpGet(Name = "Session")]
    string GetSession(){
        string session = "";
        return session;
    }

}