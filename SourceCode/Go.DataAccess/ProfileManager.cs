using Go.Common;
using Go.Common.Entities;
using Go.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Go.DataAccess
{
    public class ProfileManager : IProfileManager
    {
        private readonly IXmlOperations _xmlOperations;
        private readonly string _profileFilePath;

        public DataTable ProfilesDT{ get; set; }

        public ProfileManager(string profileFilePath, string applicationStartupPath)
            : this(new XmlOperations(applicationStartupPath), profileFilePath, applicationStartupPath)
        {

        }
        public ProfileManager(IXmlOperations xmlOperations, string profileFilePath,
            string applicationStartupPath)
        {
            _xmlOperations = xmlOperations;
            //TODO parallel reading
            profileFilePath = applicationStartupPath + "\\" + profileFilePath;
            _profileFilePath = profileFilePath;
            ProfilesDT = _xmlOperations.GetXml(profileFilePath);
        }


        public bool isThisExists(string profileName)
        {
            DataView profileDV = new DataView(ProfilesDT)
            {
                Sort = "Name"
            };

            int commandIndex = profileDV.Find(profileName);

            if (commandIndex == -1)
                return false;
            return true;
        }

        public List<string> GetAllProfileNames()
        {
            List<string> lstProfileNames = new List<string>();
            foreach (DataRow dr in ProfilesDT.Rows)
            {
                lstProfileNames.Add(dr["Name"].ToString());
            }
            return lstProfileNames;
        }
        public List<Profile> GetAll()
        {
            List<Profile> lstProfile = new List<Profile>();
            foreach (DataRow item in ProfilesDT.Rows)
            {
                lstProfile.Add(new Profile()
                {
                    Name = item[Constants.Name].ToString(),
                    CommandFilePath = item[Constants.CommandFilePath].ToString()
                });
            }
            return lstProfile;
        }
        public bool Add(Profile newProfile)
        {
            var profileDTCopy = ProfilesDT.Copy();
            DataRow profileDTRow = profileDTCopy.NewRow();
            profileDTRow[Constants.Name] = newProfile.Name;
            profileDTRow[Constants.CommandFilePath] = newProfile.CommandFilePath;
            profileDTCopy.Rows.Add(profileDTRow);

            _xmlOperations.WriteXml(profileDTCopy, _profileFilePath,XmlType.Profile);
            ProfilesDT = profileDTCopy;
            return true;
        }

        public bool Update(Profile oldProfile, Profile newProfile)
        {
            bool isProfilePathChanged = false;

            var copyProfilesDT = ProfilesDT.Copy();
            foreach (DataRow dr in copyProfilesDT.Rows)
            {
                if (dr[Constants.Name].ToString() == oldProfile.Name)
                {
                    //found the row, so update
                    if (dr[Constants.CommandFilePath].ToString() != newProfile.CommandFilePath)
                        isProfilePathChanged = true;
                    dr[Constants.Name] = newProfile.Name;
                    dr[Constants.CommandFilePath] = newProfile.CommandFilePath;
                }
                else
                    continue;
            }
            //Move the file from old path to new path if its different
            if (isProfilePathChanged)
            {
                File.Move(oldProfile.CommandFilePath, newProfile.CommandFilePath);
            }
            //write to xml file
            _xmlOperations.WriteXml(copyProfilesDT, _profileFilePath,XmlType.Profile);
            ProfilesDT  = copyProfilesDT;
            return true;
        }

        public DataTable GetProfileDT()
        {
            return ProfilesDT;
        }

        public bool Delete(string profileName)
        {
            //delete the profile
            var copyProfilesDT = ProfilesDT.Copy();
            foreach (DataRow dataRow in copyProfilesDT.Rows)
            {
                if (dataRow[Constants.Name].ToString() == profileName)
                {
                    copyProfilesDT.Rows.Remove(dataRow);
                    break;
                }
            }
            _xmlOperations.WriteXml(copyProfilesDT, _profileFilePath,XmlType.Profile);
            ProfilesDT = copyProfilesDT;

            return true;
        }

        public Profile Get(string profileName)
        {
            Profile profile = null;
            //1. Find the profile of the given command
            DataView commandDV = new DataView(ProfilesDT)
            {
                Sort = "Name"
            };
            int commandIndex = commandDV.Find(profileName);

            if (commandIndex == -1)
                return null;
            else
            {
                profile = new Profile
                {
                    Name = profileName,
                    CommandFilePath = GetCommandPath(profileName)
                };
                return profile;
            }
        }

        public string GetCommandPath(string profileName)
        {
            var profileCommandPath = string.Empty;
            foreach (DataRow item in ProfilesDT.Rows)
            {
                if (item[Constants.Name].ToString() == profileName)
                {
                    profileCommandPath = item[Constants.CommandFilePath].ToString();
                    break;
                }
            }
            return profileCommandPath;
        }
    }
}
