﻿using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}