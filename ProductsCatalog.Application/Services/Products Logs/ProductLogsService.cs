﻿using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Application.Services.Products_Logs
{
    public class ProductLogsService : IProductLogsService
    {
        private readonly IProductUpdateLogsRepository productUpdateLogsRepository;

        public ProductLogsService(IProductUpdateLogsRepository productUpdateLogsRepository)
        {
            this.productUpdateLogsRepository = productUpdateLogsRepository;
        }
    }
}