export interface Renter {
    id: number;
    name: string;
    mobileNo1: number;
    mobileNo2: number;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
}
