using System.ComponentModel.DataAnnotations;

namespace WH.Domain.Models.InformationRegister
{
    public class InformationRegisterТэгиПартнеров : Entity
    {
        [MaxLength(AppSettings.GUID)] public string? Партнер_Key { get; set; }
        [MaxLength(AppSettings.GUID)] public string? Тэг_Key { get; set; }
    }
}
