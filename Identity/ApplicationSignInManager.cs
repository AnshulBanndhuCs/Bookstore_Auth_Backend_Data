﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Auth_Backend_API_DataAccess.Identity
{
    public class ApplicationSignInManager : SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(ApplicationUserManager applicationUserManager,
     IHttpContextAccessor httpContextAccessor, IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
     IOptions<IdentityOptions> options, ILogger<ApplicationSignInManager> logger,
     IAuthenticationSchemeProvider authenticationSchemeProvider, IUserConfirmation<ApplicationUser> userConfirmation
     ) : base(applicationUserManager, httpContextAccessor, userClaimsPrincipalFactory, options, logger, authenticationSchemeProvider, userConfirmation)
        {
        }
    }
}
//to avoid and solve the error of 7arguments in SignInManager
//Add below code in DataAccess porject package sheet
//< ItemGroup >
//  < FrameworkReference Include = "Microsoft.AspNetCore.App" />
//</ ItemGroup > 
