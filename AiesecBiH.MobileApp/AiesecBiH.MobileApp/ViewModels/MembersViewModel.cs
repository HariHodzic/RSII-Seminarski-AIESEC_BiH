using AiesecBiH.Model.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class MembersViewModel:BaseViewModel
    {
        private readonly APIService _membersService = new APIService("Members");
        private readonly APIService _functionalFieldService = new APIService("FunctionalFields");
        private readonly APIService _localCommitteeService = new APIService("LocalCommittees");
        public ObservableCollection<Model.Response.MemberLL> MembersList { get; set; } = new ObservableCollection<Model.Response.MemberLL>();
        public ObservableCollection<Model.Response.FunctionalField> FunctionalFieldsList { get; set; } = new ObservableCollection<Model.Response.FunctionalField>();
        public ObservableCollection<Model.Response.LocalCommittee> LocalCommitteesList { get; set; } = new ObservableCollection<Model.Response.LocalCommittee>();
        public ICommand InitCommand { get; set; }
        FunctionalField _selectedFunctionalField = null;
        LocalCommittee _selectedLocalCommittee = null;

        public MembersViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public FunctionalField SelectedFunctionalField
        {
            get { return _selectedFunctionalField; }
            set
            {
                SetProperty(ref _selectedFunctionalField, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public LocalCommittee SelectedLocalCommittee
        {
            get { return _selectedLocalCommittee; }
            set
            {
                SetProperty(ref _selectedLocalCommittee, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public async System.Threading.Tasks.Task Init()
        {
            if (FunctionalFieldsList.Count == 0)
            {
                var functionalFieldsList = await _functionalFieldService.Get<List<FunctionalField>>(null);

                foreach (var funcField in functionalFieldsList)
                {
                    FunctionalFieldsList.Add(funcField);
                }
            }
            if (LocalCommitteesList.Count == 0)
            {
                var localCommittees = await _localCommitteeService.Get<List<LocalCommittee>>(null);

                foreach (var localCommittee in localCommittees)
                {
                    LocalCommitteesList.Add(localCommittee);
                }
            }
            Model.Search.Member searchMember = new Model.Search.Member();
            if (SelectedFunctionalField != null)
            {
                searchMember.FunctionalFieldId = SelectedFunctionalField.Id;
                var list = await _membersService.Get<IEnumerable<Model.Response.MemberLL>>(searchMember);
                MembersList.Clear();
                foreach (var member in list)
                {
                    MembersList.Add(member);
                }
            }
            if (SelectedLocalCommittee != null)
            {
                searchMember.LocalCommitteeId = SelectedLocalCommittee.Id;
                var list = await _membersService.Get<IEnumerable<Model.Response.MemberLL>>(searchMember);
                MembersList.Clear();
                foreach (var member in list)
                {
                    MembersList.Add(member);
                }
            }
            if(SelectedFunctionalField ==null && SelectedLocalCommittee==null)
            {
                var list = await _membersService.Get<IEnumerable<Model.Response.MemberLL>>(null);
                MembersList.Clear();
                foreach (var member in list)
                {
                    MembersList.Add(member);
                }
            }
        }
    }
}
