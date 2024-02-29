using Volo.Abp.Settings;

namespace OrderManagement.Settings;

public class OrderManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OrderManagementSettings.MySetting1));
    }
}
