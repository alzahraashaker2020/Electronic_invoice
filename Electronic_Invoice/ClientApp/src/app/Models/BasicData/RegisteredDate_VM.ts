import { countries_VM } from "./countries_VM";
import { activityTypes_VM } from "./activityTypes_VM";
import { AddressValidations_VM } from "./addressValidation_VM";

export class RegisteredDate_VM {
  constructor
    (
    public countries_VM?: countries_VM[],
    public activityTypes_VM?: activityTypes_VM[],
    public AddressValidations_VM?: AddressValidations_VM[],
    ) { }
}
