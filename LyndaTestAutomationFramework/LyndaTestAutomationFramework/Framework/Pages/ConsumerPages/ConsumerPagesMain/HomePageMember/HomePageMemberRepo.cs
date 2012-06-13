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

namespace ConsumerPagesMain.HomePageMember
{
    /// <summary>
    /// The class representing the HomePageMemberRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.3.0")]
    [RepositoryFolder("d4e8c92d-ca76-47f6-b467-d5e40e210536")]
    public partial class HomePageMemberRepo : RepoGenBaseFolder
    {
        static HomePageMemberRepo instance = new HomePageMemberRepo();
        HomePageMemberRepoFolders.DOMbaseAppFolder _dombase;

        /// <summary>
        /// Gets the singleton class instance representing the HomePageMemberRepo element repository.
        /// </summary>
        [RepositoryFolder("d4e8c92d-ca76-47f6-b467-d5e40e210536")]
        public static HomePageMemberRepo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HomePageMemberRepo() 
            : base("HomePageMemberRepo", "", null, 30000, false, "d4e8c92d-ca76-47f6-b467-d5e40e210536", "./RepositoryImages\\HomePageMemberRepod4e8c92d.rximgres")
        {
            _dombase = new HomePageMemberRepoFolders.DOMbaseAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The DOMbase folder.
        /// </summary>
        [RepositoryFolder("00ec6c98-0b85-45c1-935d-b288fd0dc41c")]
        public virtual HomePageMemberRepoFolders.DOMbaseAppFolder DOMbase
        {
            get { return _dombase; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.3.0")]
    public partial class HomePageMemberRepoFolders
    {
        /// <summary>
        /// The DOMbaseAppFolder folder.
        /// </summary>
        [RepositoryFolder("00ec6c98-0b85-45c1-935d-b288fd0dc41c")]
        public partial class DOMbaseAppFolder : RepoGenBaseFolder
        {
            HomePageMemberRepoFolders.LatestReleaseTabsFolder _latestreleasetabs;
            RepoItemInfo _selfInfo;

            /// <summary>
            /// Creates a new DOMbase  folder.
            /// </summary>
            public DOMbaseAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DOMbase", "/dom", parentFolder, 30000, false, "00ec6c98-0b85-45c1-935d-b288fd0dc41c", "")
            {
                _latestreleasetabs = new HomePageMemberRepoFolders.LatestReleaseTabsFolder(this);
                _selfInfo = new RepoItemInfo(this, "Self", "", 0, null, "00ec6c98-0b85-45c1-935d-b288fd0dc41c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("00ec6c98-0b85-45c1-935d-b288fd0dc41c")]
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
            [RepositoryItemInfo("00ec6c98-0b85-45c1-935d-b288fd0dc41c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LatestReleaseTabs folder.
            /// </summary>
            [RepositoryFolder("cd1bb5e7-57e4-4763-b036-ae2fccefc5b9")]
            public virtual HomePageMemberRepoFolders.LatestReleaseTabsFolder LatestReleaseTabs
            {
                get { return _latestreleasetabs; }
            }
        }

        /// <summary>
        /// The LatestReleaseTabsFolder folder.
        /// </summary>
        [RepositoryFolder("cd1bb5e7-57e4-4763-b036-ae2fccefc5b9")]
        public partial class LatestReleaseTabsFolder : RepoGenBaseFolder
        {
            RepoItemInfo _audioInfo;

            /// <summary>
            /// Creates a new LatestReleaseTabs  folder.
            /// </summary>
            public LatestReleaseTabsFolder(RepoGenBaseFolder parentFolder) :
                    base("LatestReleaseTabs", "", parentFolder, 0, false, "cd1bb5e7-57e4-4763-b036-ae2fccefc5b9", "")
            {
                _audioInfo = new RepoItemInfo(this, "Audio", "body/div[5]/div[2]/.//div[@id='latestNewReleases']/div[@id='latestNewReleasesContent']/div[@id='latestFilter']/a[@innertext='Audio']", 30000, null, "7977011c-0206-4eef-9b84-1662a0177602");
            }

            /// <summary>
            /// The Audio item.
            /// </summary>
            [RepositoryItem("7977011c-0206-4eef-9b84-1662a0177602")]
            public virtual Ranorex.ATag Audio
            {
                get
                {
                    return _audioInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Audio item info.
            /// </summary>
            [RepositoryItemInfo("7977011c-0206-4eef-9b84-1662a0177602")]
            public virtual RepoItemInfo AudioInfo
            {
                get
                {
                    return _audioInfo;
                }
            }
        }

    }
}