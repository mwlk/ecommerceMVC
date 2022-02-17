﻿using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
