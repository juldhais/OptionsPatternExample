using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionsPatternExample.Controllers;

[ApiController]
[Route("company")]
public class CompanyController : ControllerBase
{
    private readonly IOptions<CompanyOptions> _companyOptions;

    public CompanyController(IOptions<CompanyOptions> companyOptions)
    {
        _companyOptions = companyOptions;
    }

    [HttpGet]
    public ActionResult<CompanyOptions> GetCompanyOptions()
    {
        var companyOptions = _companyOptions.Value;
        return Ok(companyOptions);
    }
}