export interface Project {
    id: number;
    name: string;
    prefix: string;
    cityId?: number;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
    mobile1: string;
    mobile2: string;
    address: string;
    email: string;
    website: string;
}
