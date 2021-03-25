export interface Tower {
    id: number;
    name: string;
    projectId?: number;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
}

