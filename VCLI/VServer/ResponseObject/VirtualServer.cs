namespace VCLI.VServer.ResponseObject
{
    public class VirtualServer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Uuid { get; set; }
        public string VirtualizationPlattform { get; set; }
        public string UserId { get; set; }
        public string HostName { get; set; }
        public string OperationSystem { get; set; }
        public string ISO { get; set; }
        public string SecureISO { get; set; }
        public string Boot { get; set; }
        public string Space { get; set; }
        public string INodes { get; set; }
        public string RAM { get; set; }
        public string Burst { get; set; }
        public string Swap { get; set; }
        public string ClockRate { get; set; }
        public string Cores { get; set; }
        public string CPUPin { get; set; }
        public string CPUPercent { get; set; }
        public string Bandwidth { get; set; }
        public string NetworkSpeed { get; set; }
        public string UploadSpeed { get; set; }
        public string IO { get; set; }
        public string EMail { get; set; }
        public string ServerName { get; set; }
        public string Distro { get; set; }
        public string Status { get; set; }
        public string IPAddress { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}