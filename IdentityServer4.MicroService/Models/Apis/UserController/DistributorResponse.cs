﻿namespace IdentityServer4.MicroService.Models.Apis.UserController
{
    public class DistributorResponse
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public long Members { get; set; }
        public decimal Sales { get; set; }
        public long ParentUserID { get; set; }
        public int LineageLevel { get; set; }
        public string Lineage { get; set; }
    }
}
