import { City } from './city';
import { Photo } from './photo';


export interface Property {
    id: number;
    propertyName: string;
    photoUrl: string;
    cityName: string;
    quarterName: string;
    towerName: string;
    areaName: string;
    blockName: string;
    categoryName: string;
    floorName: string;
    interfaceName: string;
    projectName: string;
    propertyTypeName: string;
    renterName: string;
    renterMobileNo1?: number;
    renterMobileNo2?: number;
    categoryId?: number;
    propertyTypeId?: number;
    projectId?: number;
    towerId?: number;
    blockId?: number;
    areaId?: number;
    interfaceId?: number;
    propertyNumber: string;
    price?: number;
    renterId?: number;
    note?: string;
    isAvailable: boolean;
    isActive?: boolean;
    isDeleted?: boolean;
    createdBy?: string;
    createdDate?: Date;
    modifiedBy?: string;
    modifiedDate?: Date;
    isFocusedOn?: boolean;
    itHasProblem?: boolean;
    isFurnished?: boolean;
    photos?: Photo[];
    city?: City[];
}



