export interface Quarter {
    id: number;
    name: string;
    prifix: string;
    cityId: string;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
}

