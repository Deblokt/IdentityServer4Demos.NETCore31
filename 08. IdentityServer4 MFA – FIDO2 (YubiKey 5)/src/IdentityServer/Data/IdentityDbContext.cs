using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer.Models;
using IdentityServer4.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IdentityServer.Data
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {

        }

        public DbSet<FidoStoredCredential> FidoStoredCredential { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FidoStoredCredential>().HasKey(f => f.Username);
            base.OnModelCreating(builder);
            //seed data
            UsersSeed(builder);
            ClientSeed(builder);
        }

        private void UsersSeed(ModelBuilder builder)
        {
            var password = "My long 123$ password";

            var alice = new ApplicationUser
            {
                Id = "1",
                UserName = "alice",
                NormalizedUserName = "ALICE",
                Email = "AliceSmith@email.com",
                NormalizedEmail = "AliceSmith@email.com".ToUpper(),
                EmailConfirmed = true                
            };
            alice.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(alice, password);

            var bob = new ApplicationUser
            {
                Id = "2",
                UserName = "bob",
                NormalizedUserName = "BOB",
                Email = "BobSmith@email.com",
                NormalizedEmail = "bobsmith@email.com".ToUpper(),
                EmailConfirmed = true, 
            };
            bob.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(bob, password);

            builder.Entity<ApplicationUser>()
                .HasData(alice, bob);

            builder.Entity<IdentityResource>().HasData
                (
                    new IdentityResource()
                    {
                        Id = 1,
                        Enabled = true,
                        Name = "openid",
                        DisplayName = "Your user identifier",
                        Description = null,
                        Required = true,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    },
                    new IdentityResource()
                    {
                        Id = 2,
                        Enabled = true,
                        Name = "profile",
                        DisplayName = "User profile",
                        Description = "Your user profile information (first name, last name, etc.)",
                        Required = false,
                        Emphasize = true,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    },
                    new IdentityResource()
                    {
                        Id = 3,
                        Enabled = true,
                        Name = "email",
                        DisplayName = "Your email address",
                        Description = null,
                        Required = false,
                        Emphasize = true,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    });

            builder.Entity<IdentityClaim>()
                .HasData(
                    new IdentityClaim
                    {
                        Id = 1,
                        IdentityResourceId = 1,
                        Type = "sub"
                    },
                    new IdentityClaim
                    {
                        Id = 2,
                        IdentityResourceId = 2,
                        Type = "email"
                    },
                    new IdentityClaim
                    {
                        Id = 3,
                        IdentityResourceId = 2,
                        Type = "website"
                    },
                    new IdentityClaim
                    {
                        Id = 4,
                        IdentityResourceId = 2,
                        Type = "given_name"
                    },
                    new IdentityClaim
                    {
                        Id = 5,
                        IdentityResourceId = 2,
                        Type = "family_name"
                    },
                    new IdentityClaim
                    {
                        Id = 6,
                        IdentityResourceId = 3,
                        Type = "email_verified"
                    },
                    new IdentityClaim
                    {
                        Id = 7,
                        IdentityResourceId = 2,
                        Type = "name"
                    });
            builder.Entity<IdentityUserClaim<string>>()
                .HasData(
                    new IdentityUserClaim<string>
                    {
                        Id = 1,
                        UserId = "1",
                        ClaimType = "name",
                        ClaimValue = "Alice Smith"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 2,
                        UserId = "1",
                        ClaimType = "given_name",
                        ClaimValue = "Alice"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 3,
                        UserId = "1",
                        ClaimType = "family_name",
                        ClaimValue = "Smith"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 4,
                        UserId = "1",
                        ClaimType = "email",
                        ClaimValue = "AliceSmith@email.com"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 5,
                        UserId = "1",
                        ClaimType = "website",
                        ClaimValue = "http://alice.com"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 6,
                        UserId = "2",
                        ClaimType = "name",
                        ClaimValue = "Bob Smith"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 7,
                        UserId = "2",
                        ClaimType = "given_name",
                        ClaimValue = "Bob"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 8,
                        UserId = "2",
                        ClaimType = "family_name",
                        ClaimValue = "Smith"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 9,
                        UserId = "2",
                        ClaimType = "email",
                        ClaimValue = "BobSmith@email.com"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 10,
                        UserId = "2",
                        ClaimType = "website",
                        ClaimValue = "http://bob.com"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 11,
                        UserId = "1",
                        ClaimType = "email_verified",
                        ClaimValue = true.ToString()
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 12,
                        UserId = "2",
                        ClaimType = "email_verified",
                        ClaimValue = true.ToString()
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 13,
                        UserId = "1",
                        ClaimType = "address",
                        ClaimValue = @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 14,
                        UserId = "2",
                        ClaimType = "address",
                        ClaimValue = @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 15,
                        UserId = "1",
                        ClaimType = "location",
                        ClaimValue = "somewhere"
                    });
        }

        private void ClientSeed(ModelBuilder builder)
        {
            builder.Entity<ApiResource>()
                .HasData(
                    new ApiResource
                    {
                        Id = 1,
                        Name = "web_api",
                        DisplayName = "My Web API"
                    }
                );           
            
            builder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = 1,
                        Enabled = true,
                        ClientId = "client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false                       
                    },
                    new Client
                    {
                        Id = 2,
                        Enabled = true,
                        ClientId = "ro.client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    },
                    new Client
                    {
                        Id = 3,
                        Enabled = true,
                        ClientId = "mvc",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "MVC Client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true
                    },
                    new Client
                    {
                        Id = 4,
                        Enabled = true,
                        ClientId = "js",
                        ProtocolType = "oidc",
                        RequireClientSecret = false,
                        RequireConsent = true,
                        ClientName = "JavaScript client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = true,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    });

            builder.Entity<ClientGrantType>()
                .HasData(
                    new ClientGrantType
                    {
                        Id = 1,
                        GrantType = "client_credentials",
                        ClientId = 1
                    },
                    new ClientGrantType
                    {
                        Id = 2,
                        GrantType = "password",
                        ClientId = 2
                    },
                    new ClientGrantType
                    {
                        Id = 3,
                        GrantType = "hybrid",
                        ClientId = 3
                    },
                    new ClientGrantType
                    {
                        Id = 4,
                        GrantType = "authorization_code",
                        ClientId = 4
                    });

            builder.Entity<ClientScope>()
                .HasData(
                    new ClientScope 
                    { 
                        Id = 1, 
                        Scope = "profile",
                        ClientId = 3 
                    },
                    new ClientScope 
                    { 
                        Id = 2, 
                        Scope = "profile",
                        ClientId = 4 
                    },
                    new ClientScope
                    { 
                        Id = 3, 
                        Scope = "web_api",
                        ClientId = 1 
                    },
                    new ClientScope
                    { 
                        Id = 4, 
                        Scope = "web_api",
                        ClientId = 2 
                    },
                    new ClientScope 
                    {
                        Id = 5, 
                        Scope = "web_api",
                        ClientId = 3 
                    },
                    new ClientScope
                    { 
                        Id = 6, 
                        Scope = "web_api", 
                        ClientId = 4 
                    },
                    new ClientScope 
                    { 
                        Id = 7, 
                        Scope = "openid",
                        ClientId = 3 
                    },
                    new ClientScope 
                    { 
                        Id = 8, 
                        Scope = "openid", 
                        ClientId = 4 
                    }
                );

            builder.Entity<ClientSecret>()
                .HasData(
                     new ClientSecret 
                     {
                         Id = 1,
                         Value = "secret".ToSha256(), 
                         Type = "SharedSecret",
                         ClientId = 3 
                     },
                     new ClientSecret 
                     {
                         Id = 2,
                         Value = "secret".ToSha256(),
                         Type = "SharedSecret", 
                         ClientId = 2 
                     },
                     new ClientSecret 
                     {
                         Id = 3,
                         Value = "secret".ToSha256(),
                         Type = "SharedSecret", 
                         ClientId = 1 
                     });

            builder.Entity<ClientPostLogoutRedirectUri>()
                .HasData(
                new ClientPostLogoutRedirectUri
                {
                    Id = 1,
                    PostLogoutRedirectUri = "http://localhost:5002/signout-callback-oidc",
                    ClientId = 3
                },
                new ClientPostLogoutRedirectUri 
                { 
                    Id = 2,
                    PostLogoutRedirectUri = "http://localhost:5003/index",
                    ClientId = 4
                });

            builder.Entity<ClientRedirectUri>()
                .HasData(
                new ClientRedirectUri
                {
                    Id = 1,
                    RedirectUri = "http://localhost:5002/signin-oidc",
                    ClientId = 3
                },
                new ClientRedirectUri
                {
                    Id = 2,
                    RedirectUri = "http://localhost:5003/callback.html",
                    ClientId = 4
                });
            builder.Entity<ClientCorsOrigin>()
                .HasData(
                new ClientCorsOrigin
                {
                    Id = 1,
                    Origin = "http://localhost:5003",
                    ClientId = 4
                });
        }
    }
}
