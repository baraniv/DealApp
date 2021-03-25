export interface Category {
    id: number;
    name: string;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
}

