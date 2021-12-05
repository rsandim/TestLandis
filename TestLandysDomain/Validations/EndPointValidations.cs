using FluentValidation;
using System;
using TesteLandysModel.Enums;
using TesteLandysModel.Models;

namespace TesteLandysDomain.Validations
{
    public class EndPointValidations : AbstractValidator<EndPoint>
    {
        public EndPointValidations() 
        {
            RuleFor(e => e.MeterFirmwareVersion).NotNull().NotEmpty().WithMessage("The field Meter Firmware Version must be inform.");

            RuleFor(e => e.MeterNumber).GreaterThan(0).WithMessage("The field Meter Number must be inform.");

            RuleFor(e => e.SerialNumber).NotNull().NotEmpty().WithMessage("The field Serial Number must be inform.");

            RuleFor(e => e.ModelId).GreaterThan(0).WithMessage($"The Model Identifier must be inform.");

            RuleFor(e => e.ModelId).InclusiveBetween((int)ModelType.NSX1P2W, (int)ModelType.NSX3P4W).
                WithMessage($"The Model Identifier must be inform with values: {Enum.GetName(ModelType.NSX1P2W)} " +
                            $" or {Enum.GetName(ModelType.NSX1P3W)} or {Enum.GetName(ModelType.NSX2P3W)} or " +
                            $"{Enum.GetName(ModelType.NSX3P4W)}.");

            RuleFor(e => e.SwitchState).GreaterThan(-1).WithMessage($"The Switch State must be inform.");
            RuleFor(e => e.SwitchState).InclusiveBetween((int)SwitchState.Disconnected, (int)SwitchState.Armed).
                WithMessage($"The Switch State must be inform with values: {Enum.GetName(SwitchState.Disconnected)} "+
                            $"or {Enum.GetName(SwitchState.Connected)} or {Enum.GetName(SwitchState.Armed)}.");
        }
    }
}
