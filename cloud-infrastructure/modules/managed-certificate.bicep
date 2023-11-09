param name string
param location string
param tags object
param environmentName string
param domainName string

resource containerAppsEnvironment 'Microsoft.App/managedEnvironments@2023-05-02-preview' existing = {
  name: environmentName
}

resource managedCertificate 'Microsoft.App/managedEnvironments/managedCertificates@2023-05-02-preview' = {
  name: name
  parent: containerAppsEnvironment
  location: location
  tags: tags
  properties: {
    subjectName: domainName
    domainControlValidation: 'CNAME'
  }
}

output certificateId string = managedCertificate.id