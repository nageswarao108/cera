﻿using CERA.CloudService;
using CERA.Entities.ViewModels;
using System.Collections.Generic;

namespace CERA.Platform
{
    public interface ICeraPlatform : ICeraCloudApiService
    {
        public string ClientName { get; set; }
        public List<CeraPlatformConfigViewModel> GetClientOnboardedPlatforms(string ClientName);
        public int OnBoardClientPlatform(AddClientPlatformViewModel platform);
        public int OnBoardOrganization(AddOrganizationViewModel OrgDetails);
        public int OnBoardCloudProvider(AddCloudPluginViewModel plugin);
    }
}