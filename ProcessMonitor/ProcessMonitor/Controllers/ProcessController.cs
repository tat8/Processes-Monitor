using System;
using Microsoft.AspNetCore.Mvc;
using ProcessMonitor.Services;

namespace ProcessMonitor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
	    private readonly IProcessService _processService;

	    public ProcessController(IProcessService processService)
	    {
		    _processService = processService;
	    }

	    [HttpGet]
	    public IActionResult Get()
	    {
		    try
		    {
			    var processes = _processService.Get();
			    return Ok(processes);
		    }
		    catch(Exception ex)
		    {
			    return BadRequest(ex.Message);
		    }
	    }
    }
}