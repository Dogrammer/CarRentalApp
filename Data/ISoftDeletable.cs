using System;

namespace CarRentalApp.Data
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}