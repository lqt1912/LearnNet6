export interface PerformanceObject {
  id: number;
  name: string;
  value: string;
  note: string;
}

export interface PerformanceObjectResponse {
  records: PerformanceObject[];
  skip: number;
  take: number;
}
