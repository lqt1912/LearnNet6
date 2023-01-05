export interface Profile {
  userPrincipalName: string
  displayName: string
  surname: string
  mail: string
  givenName: string
  OId: string
  userType: string
  jobTitle: string
  department: string
  accountEnabled: string
  usageLocation: string
  streetAddress: string
  state: string
  country: string
  officeLocation: string
  city: string
  postalCode: string
  telephoneNumber: string
  mobilePhone: string
  alternateEmailAddress: string
  ageGroup: string
  consentProvidedForMinor: string
  legalAgeGroupClassification: string
  companyName: string
  creationType: string
  directorySynced: string
  invitationState: string
  identityIssuer: string
  createdDateTime: string
  id: string
}
export interface User extends Profile {}
