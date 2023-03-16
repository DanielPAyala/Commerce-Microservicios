using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventHandler : INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductCreateEventHandler> _logger;
        public ProductCreateEventHandler(ApplicationDbContext context, ILogger<ProductCreateEventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Name = command.Name,
                Description = command.Description,
                Price = command.Price
            });

            await _context.SaveChangesAsync();
        }
    }
}
