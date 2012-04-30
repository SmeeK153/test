///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ConsumerPagesMain.RegStep1
{
    /// <summary>
    /// The class representing the AccountInfoRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.2.3"), RepositoryFolder("5ac99b8c-7c79-4aab-b72e-c7919e4b02bf")]
    public partial class AccountInfoRepo : RepoGenBaseFolder
    {
        static AccountInfoRepo instance = new AccountInfoRepo();

        /// <summary>
        /// Gets the singleton class instance representing the AccountInfoRepo element repository.
        /// </summary>
        [RepositoryFolder("5ac99b8c-7c79-4aab-b72e-c7919e4b02bf")]
        public static AccountInfoRepo Instance
        {
            get { return instance; }
        }

        AccountInfoRepoFolders.DOMAppFolder _dom;

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AccountInfoRepo() 
            : base("AccountInfoRepo", "", null, 30000, false)
        {
            _dom = new AccountInfoRepoFolders.DOMAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The DOM folder.
        /// </summary>
        [RepositoryFolder("89597d3b-6b55-44a6-aaa5-914eedf6a09b")]
        public virtual AccountInfoRepoFolders.DOMAppFolder DOM
        {
            get { return _dom; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    public partial class AccountInfoRepoFolders
    {
        /// <summary>
        /// The DOMAppFolder folder.
        /// </summary>
        [RepositoryFolder("89597d3b-6b55-44a6-aaa5-914eedf6a09b")]
        public partial class DOMAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _selfInfo;
            RepoItemInfo _firstnameinputInfo;
            RepoItemInfo _lastnameinputInfo;
            RepoItemInfo _emailinputInfo;
            RepoItemInfo _usernameinputInfo;
            RepoItemInfo _passwordinputInfo;
            RepoItemInfo _passwordconfirminputInfo;
            RepoItemInfo _newslettersinputInfo;
            RepoItemInfo _newreleasesinputInfo;
            RepoItemInfo _specialinputInfo;

            /// <summary>
            /// Creates a new DOM  folder.
            /// </summary>
            public DOMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DOM", "/dom", parentFolder, 30000, false, "89597d3b-6b55-44a6-aaa5-914eedf6a09b")
            {
                _selfInfo = new RepoItemInfo(this, "Self", "", 0, null, "89597d3b-6b55-44a6-aaa5-914eedf6a09b");
                _firstnameinputInfo = new RepoItemInfo(this, "FirstNameInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[1]/td[2]/input[@id='txtFirstName']", 30000, null, "565efb7d-4da0-4681-9ed3-475bef29f1f6");
                _lastnameinputInfo = new RepoItemInfo(this, "LastNameInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[2]/td[2]/input[@id='txtLastName']", 30000, null, "9e7b4b0f-cd18-49d8-9caf-46531e2318ba");
                _emailinputInfo = new RepoItemInfo(this, "EmailInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[3]/td[2]/input[@id='txtEmail']", 30000, null, "1455b65f-bf2a-489f-9b68-6610b5f50763");
                _usernameinputInfo = new RepoItemInfo(this, "UsernameInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[4]/td[2]/input[@id='txtUserName']", 30000, null, "49b9cea1-9ee0-45ce-897c-e5e22679b4f9");
                _passwordinputInfo = new RepoItemInfo(this, "PasswordInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[5]/td[2]/input[@id='txtPassword']", 30000, null, "19313008-a281-4b6d-8a10-02bf86bfebc2");
                _passwordconfirminputInfo = new RepoItemInfo(this, "PasswordConfirmInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[6]/td[2]/input[@id='txtPasswordConfirm']", 30000, null, "d4fdc522-cfea-4fc3-b255-22c4c970c153");
                _newslettersinputInfo = new RepoItemInfo(this, "NewslettersInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[7]/td[2]/input[@id='Checkbox1' and @name='cknews876492']", 30000, null, "c1946865-1de2-41af-b1c1-7a43d3e4a5f9");
                _newreleasesinputInfo = new RepoItemInfo(this, "NewReleasesInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[7]/td[2]/input[@id='Checkbox1' and @name='cknews876494']", 30000, null, "a6be849f-f914-4250-8a64-2e0aff76b812");
                _specialinputInfo = new RepoItemInfo(this, "SpecialInput", "body/div[1]/div[2]/form/fieldset/div[1]/table/tbody/tr[7]/td[2]/input[@id='Checkbox1' and @name='cknews2192942']", 30000, null, "6d9437c6-1e91-42c3-8d22-3c6c27c2fe1a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("89597d3b-6b55-44a6-aaa5-914eedf6a09b")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("89597d3b-6b55-44a6-aaa5-914eedf6a09b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstNameInput item.
            /// </summary>
            [RepositoryItem("565efb7d-4da0-4681-9ed3-475bef29f1f6")]
            public virtual Ranorex.InputTag FirstNameInput
            {
                get
                {
                    return _firstnameinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FirstNameInput item info.
            /// </summary>
            [RepositoryItemInfo("565efb7d-4da0-4681-9ed3-475bef29f1f6")]
            public virtual RepoItemInfo FirstNameInputInfo
            {
                get
                {
                    return _firstnameinputInfo;
                }
            }

            /// <summary>
            /// The LastNameInput item.
            /// </summary>
            [RepositoryItem("9e7b4b0f-cd18-49d8-9caf-46531e2318ba")]
            public virtual Ranorex.InputTag LastNameInput
            {
                get
                {
                    return _lastnameinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LastNameInput item info.
            /// </summary>
            [RepositoryItemInfo("9e7b4b0f-cd18-49d8-9caf-46531e2318ba")]
            public virtual RepoItemInfo LastNameInputInfo
            {
                get
                {
                    return _lastnameinputInfo;
                }
            }

            /// <summary>
            /// The EmailInput item.
            /// </summary>
            [RepositoryItem("1455b65f-bf2a-489f-9b68-6610b5f50763")]
            public virtual Ranorex.InputTag EmailInput
            {
                get
                {
                    return _emailinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The EmailInput item info.
            /// </summary>
            [RepositoryItemInfo("1455b65f-bf2a-489f-9b68-6610b5f50763")]
            public virtual RepoItemInfo EmailInputInfo
            {
                get
                {
                    return _emailinputInfo;
                }
            }

            /// <summary>
            /// The UsernameInput item.
            /// </summary>
            [RepositoryItem("49b9cea1-9ee0-45ce-897c-e5e22679b4f9")]
            public virtual Ranorex.InputTag UsernameInput
            {
                get
                {
                    return _usernameinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UsernameInput item info.
            /// </summary>
            [RepositoryItemInfo("49b9cea1-9ee0-45ce-897c-e5e22679b4f9")]
            public virtual RepoItemInfo UsernameInputInfo
            {
                get
                {
                    return _usernameinputInfo;
                }
            }

            /// <summary>
            /// The PasswordInput item.
            /// </summary>
            [RepositoryItem("19313008-a281-4b6d-8a10-02bf86bfebc2")]
            public virtual Ranorex.InputTag PasswordInput
            {
                get
                {
                    return _passwordinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The PasswordInput item info.
            /// </summary>
            [RepositoryItemInfo("19313008-a281-4b6d-8a10-02bf86bfebc2")]
            public virtual RepoItemInfo PasswordInputInfo
            {
                get
                {
                    return _passwordinputInfo;
                }
            }

            /// <summary>
            /// The PasswordConfirmInput item.
            /// </summary>
            [RepositoryItem("d4fdc522-cfea-4fc3-b255-22c4c970c153")]
            public virtual Ranorex.InputTag PasswordConfirmInput
            {
                get
                {
                    return _passwordconfirminputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The PasswordConfirmInput item info.
            /// </summary>
            [RepositoryItemInfo("d4fdc522-cfea-4fc3-b255-22c4c970c153")]
            public virtual RepoItemInfo PasswordConfirmInputInfo
            {
                get
                {
                    return _passwordconfirminputInfo;
                }
            }

            /// <summary>
            /// The NewslettersInput item.
            /// </summary>
            [RepositoryItem("c1946865-1de2-41af-b1c1-7a43d3e4a5f9")]
            public virtual Ranorex.InputTag NewslettersInput
            {
                get
                {
                    return _newslettersinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The NewslettersInput item info.
            /// </summary>
            [RepositoryItemInfo("c1946865-1de2-41af-b1c1-7a43d3e4a5f9")]
            public virtual RepoItemInfo NewslettersInputInfo
            {
                get
                {
                    return _newslettersinputInfo;
                }
            }

            /// <summary>
            /// The NewReleasesInput item.
            /// </summary>
            [RepositoryItem("a6be849f-f914-4250-8a64-2e0aff76b812")]
            public virtual Ranorex.InputTag NewReleasesInput
            {
                get
                {
                    return _newreleasesinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The NewReleasesInput item info.
            /// </summary>
            [RepositoryItemInfo("a6be849f-f914-4250-8a64-2e0aff76b812")]
            public virtual RepoItemInfo NewReleasesInputInfo
            {
                get
                {
                    return _newreleasesinputInfo;
                }
            }

            /// <summary>
            /// The SpecialInput item.
            /// </summary>
            [RepositoryItem("6d9437c6-1e91-42c3-8d22-3c6c27c2fe1a")]
            public virtual Ranorex.InputTag SpecialInput
            {
                get
                {
                    return _specialinputInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The SpecialInput item info.
            /// </summary>
            [RepositoryItemInfo("6d9437c6-1e91-42c3-8d22-3c6c27c2fe1a")]
            public virtual RepoItemInfo SpecialInputInfo
            {
                get
                {
                    return _specialinputInfo;
                }
            }
        }

    }
}