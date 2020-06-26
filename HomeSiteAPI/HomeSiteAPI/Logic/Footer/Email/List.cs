using HomeSiteAPI.Data;
using HomeSiteAPI.Models.Footer;
using MediatR;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HomeSiteAPI.Logic.Footer.Email
{
    public class List
    {
        public class Query : IRequest<List<EmailModel>> { }

        public class Handler : IRequestHandler<Query, List<EmailModel>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<EmailModel>> Handle(Query request, CancellationToken cancellationToken)
            {
                var emails = await _context.Emails.ToListAsync();

                return emails;
            }
        }
    }
}
